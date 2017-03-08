using System;

namespace SubtitlesSync.Domain
{
    public class Subtitle
    {
        public int Number { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Text { get; set; }
        public TimeSpan Duration
        {
            get
            {
                return End.Subtract(Start);
            }
        }
    }
}
