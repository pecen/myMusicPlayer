using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicPlayer.Dal.Dto
{
    public class ItemDto
    {
        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrlDto ExternalUrls { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public ImageDto[] Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public OwnerDto Owner { get; set; }

        [JsonProperty("primary_color")]
        public object PrimaryColor { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }

        [JsonProperty("tracks")]
        public TracksDto Tracks { get; set; }

        [JsonProperty("type")]
        //public ItemType Type { get; set; }
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
