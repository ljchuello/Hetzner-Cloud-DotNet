using Newtonsoft.Json;

namespace HetznerDotNet.Objects.LoadBalancer.GetOne
{
    public class Response
    {
        [JsonProperty("load_balancer")]
        public Api.LoadBalancer LoadBalancer { get; set; }
    }
}
