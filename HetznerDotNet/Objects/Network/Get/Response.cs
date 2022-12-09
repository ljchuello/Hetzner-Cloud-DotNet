using HetznerCloudApi.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Network.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta? meta { get; set; }

        [JsonProperty("networks")]
        public List<Api.Network>? networks { get; set; }
    }
}
