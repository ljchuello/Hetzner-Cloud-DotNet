using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Volume.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("volumes")]
        public List<Api.Volume>? Volumes { get; set; }
    }
}
