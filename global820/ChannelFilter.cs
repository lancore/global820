using System;

namespace global820
{
    [Serializable]
    public class ChannelFilter
    {
        public bool Local { get; set; }
        public bool Global { get; set; }
        public bool Whisper { get; set; }
        public bool Trade { get; set; }
        public bool Guild { get; set; }
        public bool Party { get; set; }
    }
}
