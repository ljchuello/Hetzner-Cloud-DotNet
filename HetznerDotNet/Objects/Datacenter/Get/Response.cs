using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Datacenter.Get
{
    public class Response
    {
        [JsonProperty("datacenters")]
        public List<Api.Datacenter> Datacenters { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }
    }
}
