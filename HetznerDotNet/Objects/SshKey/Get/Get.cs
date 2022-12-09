using System.Collections.Generic;
using HetznerDotNet.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.SshKey.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("ssh_keys")]
        public List<Api.SshKey>? SshKeys { get; set; }
    }
}
