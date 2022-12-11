using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.LoadBalancer.Get
{
    public class Response
    {
        [JsonProperty("load_balancers")]
        public List<Api.LoadBalancer>? LoadBalancers { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }
    }
}
