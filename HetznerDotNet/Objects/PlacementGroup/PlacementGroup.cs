using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.PlacementGroup
{
    public class PlacementGroup
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("servers")]
        public List<int?>? Servers { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
