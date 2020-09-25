using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMusicLibrary.Model
{
    public class YoutubeTime
    {
        private int secsFrom { get; set; }
        private int secsTo { get; set; }
        public string Title { get; set; }

        public YoutubeTime(string[] from, string[] to, string title)
        {
            Title = title;
            bool successfullfrom = false;
            bool successfullto = false;

            if (from.Length == 3)
            {
                int fromSecs = int.Parse(from[0]) * 3600 + int.Parse(from[1]) * 60 + int.Parse(from[2]);
                successfullfrom = true;
                secsFrom = fromSecs;
            }
            if (to.Length == 3)
            {
                if (to[2].Contains("."))
                {
                    int dotIndex = to[2].IndexOf('.');
                    to[2] = to[2].Substring(0, dotIndex);
                }
                int toSecs = int.Parse(to[0]) * 3600;
                toSecs += int.Parse(to[1]) * 60;
                toSecs += int.Parse(to[2]);
                successfullto = true;
                secsTo = toSecs;
            }
            if (to.Length == 2)
            {
                int toSecs = int.Parse(to[0]) * 60 + int.Parse(to[1]);
                successfullto = true;
                secsTo = toSecs;
            }
            if (from.Length == 2)
            {
                int fromSecs = int.Parse(from[0]) * 60 + int.Parse(from[1]);
                successfullfrom = true;
                secsFrom = fromSecs;
            }
            if (successfullfrom == false || successfullto == false)
            {
                throw new Exception("Conversion failed");
            }
        }
        public TimeSpan FromTime => TimeSpan.FromSeconds(secsFrom);
        public TimeSpan Duration => TimeSpan.FromSeconds(secsTo - secsFrom);
        public override string ToString() => $"{Title} {secsFrom} {secsTo}";
    }
}
