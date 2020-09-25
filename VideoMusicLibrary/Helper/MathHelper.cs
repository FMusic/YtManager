using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.VideoMusicLibrary
{
    public static class MathHelper
    {
        public static int GetPercentage(long howMuch, long of) => (int) (howMuch / of) * 100;
    }
}
