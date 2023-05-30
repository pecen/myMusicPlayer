using Newtonsoft.Json;
using System;

namespace myMusicPlayer.Dal.Dto
{
    public class PlaylistDto
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("items")]
        public ItemDto[] Items { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
