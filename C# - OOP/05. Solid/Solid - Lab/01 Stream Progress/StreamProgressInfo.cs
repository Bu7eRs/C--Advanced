using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IProgressable progressable;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IProgressable progressable)
        {
            this.progressable = progressable;
        }

        public int CalculateCurrentPercent()
        {
            return (this.progressable.Sent * 100) / this.progressable.Length;
        }
    }
}
