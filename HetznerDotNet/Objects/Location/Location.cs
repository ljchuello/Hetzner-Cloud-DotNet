using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Location
{
    public class Location
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("city")]
        public string? city { get; set; }

        [JsonProperty("country")]
        public string? country { get; set; }

        [JsonProperty("description")]
        public string? description { get; set; }

        [JsonProperty("latitude")]
        public double? latitude { get; set; }

        [JsonProperty("longitude")]
        public double? longitude { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }

        [JsonProperty("network_zone")]
        public string? network_zone { get; set; }
    }
}
