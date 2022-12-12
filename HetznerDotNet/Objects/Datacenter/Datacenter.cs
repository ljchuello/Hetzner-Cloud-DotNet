using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Datacenter
{
    public class Datacenter
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("server_types")]
        public ServerTypes ServerTypes { get; set; }
    }

    public class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network_zone")]
        public string NetworkZone { get; set; }
    }

    public class ServerTypes
    {
        [JsonProperty("available")]
        public List<int> Available { get; set; }

        [JsonProperty("available_for_migration")]
        public List<int> AvailableForMigration { get; set; }

        [JsonProperty("supported")]
        public List<int> Supported { get; set; }
    }
}
