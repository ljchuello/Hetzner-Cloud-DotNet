using Newtonsoft.Json;

namespace HetznerDotNet.Objects.PlacementGroup.GetOne
{
    public class Response
    {
        [JsonProperty("placement_group")]
        public Api.PlacementGroup? PlacementGroup { get; set; }
    }
}
