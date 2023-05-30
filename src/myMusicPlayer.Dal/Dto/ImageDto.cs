using Newtonsoft.Json;
using System;

namespace myMusicPlayer.Dal.Dto
{
    public class ImageDto
    {
        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }
    }
}
