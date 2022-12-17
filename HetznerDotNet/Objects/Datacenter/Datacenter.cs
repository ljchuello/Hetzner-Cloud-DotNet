using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Datacenter
{
    public class Datacenter
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("location")]
        public Api.Location? Location { get; set; }

        [JsonProperty("server_types")]
        public ServerTypes? ServerTypes { get; set; }
    }

    public class ServerTypes
    {
        [JsonProperty("supported")]
        public List<int>? Supported { get; set; }

        [JsonProperty("available")]
        public List<int>? Available { get; set; }

        [JsonProperty("available_for_migration")]
        public List<int>? AvailableForMigration { get; set; }
    }
}
