using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Location
{
    public class Location
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("network_zone")]
        public string? NetworkZone { get; set; }
    }
}
