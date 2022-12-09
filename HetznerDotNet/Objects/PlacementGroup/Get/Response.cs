using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.PlacementGroup.Get
{
    public class Response
    {
        [JsonProperty("placement_groups")]
        public List<Api.PlacementGroup>? PlacementGroups { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }
    }
}
