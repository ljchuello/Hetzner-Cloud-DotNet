using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Network.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta? meta { get; set; }

        [JsonProperty("networks")]
        public List<Api.Network>? networks { get; set; }
    }
}
