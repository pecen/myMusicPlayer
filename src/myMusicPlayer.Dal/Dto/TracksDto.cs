using Newtonsoft.Json;
using System;

namespace myMusicPlayer.Dal.Dto
{
    public class TracksDto
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
