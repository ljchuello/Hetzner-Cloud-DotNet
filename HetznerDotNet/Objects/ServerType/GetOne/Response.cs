using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.ServerType.GetOne
{
    public class Response
    {
        [JsonProperty("server_type")]
        public Api.ServerType? server_type { get; set; }
    }
}
