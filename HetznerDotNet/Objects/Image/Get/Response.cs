using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Image.Get
{
    public class Response
    {
        [JsonProperty("images")]
        public List<Api.Image>? images { get; set; }

        [JsonProperty("meta")]
        public Meta? meta { get; set; }
    }
}
