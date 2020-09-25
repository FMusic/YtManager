using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMusicDownloader.Model
{
    public class DownloadProgess
    {
        public int ProgressPerc { get; set; }
    }

    public class ConvertProgress
    {
        public string Title { get; set; }
        public int ProgressPerc { get; set; }
    }
}
