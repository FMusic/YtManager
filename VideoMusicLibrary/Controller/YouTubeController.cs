using Helper.VideoMusicLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using VideoLibrary;
using VideoMusicLibrary;
using VideoMusicLibrary.Controller;
using VideoMusicLibrary.Model;

namespace VideoMusicDownloader.Controller
{
    public class YouTubeController
    {
        public static async Task<VideoInfo> LoadVideoAsync(string link)
        {
            var info = new VideoInfo();
            var client = new HttpClient();
            var video = await YouTube.Default.GetVideoAsync(link);
            link = link.Replace("https", "http");
            client.BaseAddress = new Uri(link);
            info.VideoUri = new Uri(video.Uri);
            using (var req = new HttpRequestMessage(HttpMethod.Head, info.VideoUri))
            {
                info.TotalBytes = (await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead)).Content.Headers.ContentLength.Value;
            }
            info.VideoName = video.Title.Remove(video.Title.LastIndexOf(" - YouTube"), 10);
            return info;
        }

        public async static Task DownloadAndSaveAsync(string fileName, Uri videoUri, IProgress<int> progress)
        {
            int totalRead = 0;
            int read;
            byte[] buffer = new byte[16 * 1024];
            var client = new HttpClient();
            long? totalByte;
            await Task.Run(async () =>
            {
                FileManager fm = new FileManager();
                await fm.OpenFile(fileName);
                using (var request = new HttpRequestMessage(HttpMethod.Head, videoUri))
                {
                    totalByte = (await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead)).Content.Headers.ContentLength;
                }
                using (var input = await client.GetStreamAsync(videoUri))
                {
                    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        await fm.WriteToFile(buffer, read);
                        totalRead += read;
                        progress.Report(MathHelper.GetPercentage(totalRead, totalByte.Value));
                    }
                }
                fm.CloseFile();
                client.Dispose();
            });
        }
    }
}
