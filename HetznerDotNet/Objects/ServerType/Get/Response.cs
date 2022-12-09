using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.ServerType.Get
{
    public class Response
    {
        [JsonProperty("server_types")]
        public List<Api.ServerType>? ServerTypes { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }
    }
}
