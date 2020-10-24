using Helper.VideoMusicLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VideoLibrary;
using VideoMusicLibrary;
using VideoMusicLibrary.Controller;
using VideoMusicLibrary.Model;
using YoutubeExplode;

namespace VideoMusicDownloader.Controller
{
    public class YouTubeController
    {
        public static readonly string playlistString = "playlist";
        private static HttpClient client;

        public static async Task<IList<VideoInfo>> LoadVideoAsync(string link, int numOfVideos)
        {
            InitClient();
            if (link.Contains(playlistString))
            {
                var linkPlaylist = link.Split("=".ToCharArray())[1];
                return await LoadPlaylist(linkPlaylist, numOfVideos);
            }
            else
            {
                return await LoadSingleFile(link);
            }
        }

        private static async Task<IList<VideoInfo>> LoadSingleFile(string link)
        {
            var list = new List<VideoInfo>
            {
                await GetInfoAsync(link)
            }; 
            return list;
        }

        private static async Task<IList<VideoInfo>> LoadPlaylist(string playlistId, int numOfVideos)
        {
            var ret = new List<VideoInfo>();
            var yt = new YoutubeClient();
            var plVideos = await yt.Playlists.GetVideosAsync(playlistId);
            foreach (var vid in plVideos)
            {
                ret.Add(await GetInfoAsync(vid.Url));
            }
            return ret;
        }


        private static async Task<VideoInfo> GetInfoAsync(string link)
        {
            var info = new VideoInfo();
            link = link.Replace("https", "http");
            Thread.Sleep(3000);
            try
            {
                var video = await YouTube.Default.GetVideoAsync(link);
                info.VideoUri = new Uri(video.Uri);
                info = getTitle(info, video);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return info;
        }

        private static VideoInfo getTitle(VideoInfo info, YouTubeVideo video)
        {
            try
            {
                info.VideoName = video.Title.Remove(video.Title.LastIndexOf(" - YouTube"), 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Video doesn't end with - Youtube");
                info.VideoName = video.Title;
            }
            return info;
        }

        private static async Task<VideoInfo> GetTotalBytes(VideoInfo info)
        {
            using (var req = new HttpRequestMessage(HttpMethod.Head, info.VideoUri))
            {
                info.TotalBytes = (await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead)).Content.Headers.ContentLength.Value;
            }
            return info;
        }

        public async static Task DownloadAndSaveAsync(string fileName, Uri videoUri, IProgress<int> progress)
        {
            InitClient();
            int totalRead = 0;
            int read;
            byte[] buffer = new byte[16 * 1024];
            long? totalByte;
            await Task.Run(async () =>
            {
                FileManager fm = new FileManager();
                fm.OpenFile(fileName);
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

        private static void InitClient()
        {
            if (client == null)
            {
                client = new HttpClient
                {
                    BaseAddress = new Uri("http://www.youtube.com")
                };
            }
        }
    }
}
