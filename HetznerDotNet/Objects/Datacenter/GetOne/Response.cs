using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Datacenter.GetOne
{
    public class Response
    {
        [JsonProperty("datacenter")]
        public Api.Datacenter Datacenter { get; set; }
    }
}
