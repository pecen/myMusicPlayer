using Newtonsoft.Json;
using System;

namespace myMusicPlayer.Dal.Dto
{
    public class ExternalUrlDto
    {
        [JsonProperty("spotify")]
        public Uri Spotify { get; set; }
    }
}
