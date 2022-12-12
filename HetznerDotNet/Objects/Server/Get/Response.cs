using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Server.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("servers")]
        public List<Api.Server>? Servers { get; set; }
    }
}
