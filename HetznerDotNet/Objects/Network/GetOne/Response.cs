﻿using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Network.GetOne
{
    public class Response
    {
        [JsonProperty("network")]
        public Api.Network? Network { get; set; }
    }
}
