using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.ServerType.Get
{
    public class Response
    {
        [JsonProperty("server_types")]
        public List<Api.ServerType>? server_types { get; set; }

        [JsonProperty("meta")]
        public Meta? meta { get; set; }
    }
}
