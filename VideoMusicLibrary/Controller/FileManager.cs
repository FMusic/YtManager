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

        public void OpenFile(string filepath)
        {
            s = File.OpenWrite(filepath);
        }

        public async Task WriteToFile(byte[] buffer, int read)
        {
            if (s!= null)
            {
                await s.WriteAsync(buffer, 0, read);
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
