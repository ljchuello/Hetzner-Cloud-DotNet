using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Firewall.Get
{
    public class Response
    {
        [JsonProperty("firewalls")]
        public List<Api.Firewall>? Firewalls { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }
    }
}
