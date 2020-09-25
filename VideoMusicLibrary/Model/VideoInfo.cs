using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMusicLibrary.Model
{
    public class VideoInfo
    {
        public long TotalBytes { get; set; }
        public int LengthInSecs { get; set; }
        public int Resolution { get; set; }
        public string VideoName { get; set; }
        public Uri VideoUri { get; set; }
    }
}
