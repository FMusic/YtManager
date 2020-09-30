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
using YoutubeExplode;

namespace VideoMusicDownloader.Controller
{
    public class YouTubeController
    {
        public static readonly string playlistString = "playlist";
        public static async Task<IList<VideoInfo>> LoadVideoAsync(string link, int numOfVideos)
        {
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
            var list = new List<VideoInfo>();
            var info = new VideoInfo();
            using (var client = new HttpClient())
            {
                var video = await YouTube.Default.GetVideoAsync(link);
                link = link.Replace("https", "http");
                client.BaseAddress = new Uri(link);
                info.VideoUri = new Uri(video.Uri);
                info = await GetTotalBytes(info, client);
                info = getTitle(info, video);
                list.Add(info);
            }
            return list;
        }

        private static VideoInfo getTitle(VideoInfo info, YouTubeVideo video)
        {
            try
            {
                info.VideoName = video.Title.Remove(video.Title.LastIndexOf(" - YouTube"), 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                info.VideoName = video.Title;
            }
            return info;
        }

        private static async Task<VideoInfo> GetTotalBytes(VideoInfo info, HttpClient client)
        {
            using (var req = new HttpRequestMessage(HttpMethod.Head, info.VideoUri))
            {
                info.TotalBytes = (await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead)).Content.Headers.ContentLength.Value;
            }
            return info;
        }

        private static async Task<IList<VideoInfo>> LoadPlaylist(string playlistId, int numOfVideos)
        {
            var ret = new List<VideoInfo>();
            var yt = new YoutubeClient();
            var pl = await yt.Playlists.GetAsync(playlistId);
            var plVideos = await yt.Playlists.GetVideosAsync(playlistId);
            using (var client = new HttpClient())
            {
                foreach (var vid in plVideos)
                {
                    var aa = vid.Url.Replace("https", "http");
                    var uri = new Uri(aa);
                    client.BaseAddress = uri;
                    var video = await YouTube.Default.GetVideoAsync(vid.Url);

                    VideoInfo vi = new VideoInfo
                    {
                        VideoUri = uri
                    };
                    vi = getTitle(vi, video);
                    vi = await GetTotalBytes(vi, client);
                    ret.Add(vi);
                }
            }
            return ret;
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
    }
}
