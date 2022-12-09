using Newtonsoft.Json;

namespace HetznerDotNet.Objects.ServerType.GetOne
{
    public class Response
    {
        [JsonProperty("server_type")]
        public Api.ServerType? server_type { get; set; }
    }
}
