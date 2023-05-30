using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicPlayer.Dal.Dto
{
    public class OwnerDto
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrlDto ExternalUrls { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        //public OwnerType Type { get; set; }
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
