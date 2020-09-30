using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VideoMusicLibrary.Controller;
using VideoMusicLibrary.Model;

namespace VideoMusicDownloader.Controller
{
    public class MP4Controller
    {
        private static Engine engine;
        public static bool running = false;
        public static async Task<bool> BreakDownFileAndSave(string filename, string[] lines, bool video, bool music, bool deleteOriginal, IProgress<string> progress)
        {
            TimeSpan dur; IList<YoutubeTime> ytTimes;
            try
            {
                dur = GetDuration(filename);
                ytTimes = GetTimes(lines, dur);
            }
            catch (Exception)
            {
                return false;
            }
            var inputFile = new MediaFile(filename);
            var outD = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename));
            var musicDirectory = Path.Combine(outD, "MP3");
            var videosDirectory = Path.Combine(outD, "MP4");
            Directory.CreateDirectory(outD);

            for (int i = 0; i < ytTimes.Count; i++)
            {
                YoutubeTime ytTime = ytTimes[i];
                if (video == true)
                {
                    Directory.CreateDirectory(videosDirectory);
                    string outName = Path.Combine(videosDirectory, ytTime.Title);
                    await SaveVideoAsync(ytTime, inputFile, outName);
                    progress.Report(ytTime.Title + " convert to MP4 finished.");
                }
                if (music == true)
                {
                    Directory.CreateDirectory(musicDirectory);
                    string outName = Path.Combine(musicDirectory, ytTime.Title);
                    await SaveMusicAsync(ytTime, inputFile, outName);
                    progress.Report(ytTime.Title + " convert to MP3 finished.");
                }
            }
            if (deleteOriginal)
            {
                File.Delete(filename);
            }
            return true;
        }

        private static async Task SaveMusicAsync(YoutubeTime ytTime, MediaFile inputFile, string outputName)
        {
            await Task.Run(() =>
            {
                using (engine = new Engine())
                {
                    running = true;
                    var options = new ConversionOptions();
                    var outputFile = new MediaFile(outputName + FileManager.extMusic);
                    engine.Convert(inputFile, outputFile);
                    running = false;
                }
            });
        }

        private static async Task SaveVideoAsync(YoutubeTime ytTime, MediaFile inputFile, string outputName)
        {
            await Task.Run(() => {
                using (engine = new Engine())
                {
                    running = true;
                    var options = new ConversionOptions();
                    var outputFile = new MediaFile(outputName + FileManager.extVideo);
                    options.CutMedia(ytTime.FromTime, ytTime.Duration);
                    engine.Convert(inputFile, outputFile, options);
                    running = false;
                }
            });
        }

        private static IList<YoutubeTime> GetTimes(string[] lines, TimeSpan dur)
        {
            IList<YoutubeTime> ytTimes = new List<YoutubeTime>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                string[] lineSplit = line.Split(' ');
                #region title
                StringBuilder titleBuilder = new StringBuilder();
                for (int j = 1; j < lineSplit.Length; j++)
                {
                    titleBuilder.Append(lineSplit[j]);
                    titleBuilder.Append(" ");
                }
                #endregion title
                string title = titleBuilder.ToString();
                YoutubeTime ytTime;
                if (i + 1 < lines.Length)
                {
                    string nextLn = lines[i + 1].Trim();
                    string[] nextLnSplit = nextLn.Split(' ');
                    ytTime = new YoutubeTime(lineSplit[0].Split(':'), nextLnSplit[0].Split(':'), title);
                }
                else
                {
                    ytTime = new YoutubeTime(lineSplit[0].Split(':'), dur.ToString().Split(':'), title);
                }
                ytTimes.Add(ytTime);
            }
            return ytTimes;
        }

        private static TimeSpan GetDuration(string filename)
        {
            var inputFile = new MediaFile
            {
                Filename = filename
            };
            using (engine = new Engine())
            {
                running = true;
                engine.GetMetadata(inputFile);
                running = false;
            }
            return inputFile.Metadata.Duration;
        }

        public static void Stop()
        {
            engine.Dispose();
        }
    }
}
