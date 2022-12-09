using HetznerCloudApi.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.ServerType.Get
{
    public class Response
    {
        [JsonProperty("server_types")]
        public List<Api.ServerType>? server_types { get; set; }

        [JsonProperty("meta")]
        public Meta? meta { get; set; }
    }
}
