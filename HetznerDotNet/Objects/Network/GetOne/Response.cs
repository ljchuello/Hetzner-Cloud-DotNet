using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Network.GetOne
{
    public class Response
    {
        [JsonProperty("network")]
        public Api.Network? network { get; set; }
    }
}
