using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VideoMusicLibrary.Controller
{
    public class FileManager
    {
        public const string extVideo = ".mp4";
        public const string extMusic = ".mp3";

        private Stream s;

        public async Task OpenFile(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            path = path + filename;
            s = File.OpenWrite(path);
        }

        public async Task WriteToFile(byte[] buffer, int read)
        {
            if (s!= null)
            {
                s.Write(buffer, 0, read);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void CloseFile()
        {
            s.Close();
        }
    }
}
