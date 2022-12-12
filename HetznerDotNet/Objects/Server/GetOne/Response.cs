using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Server.GetOne
{
    public class Response
    {
        [JsonProperty("server")]
        public Api.Server Server { get; set; }
    }
}
