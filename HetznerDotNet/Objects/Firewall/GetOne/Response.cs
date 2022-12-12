using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Firewall.GetOne
{
    public class Response
    {
        [JsonProperty("firewall")]
        public Api.Firewall? Firewall { get; set; }
    }
}
