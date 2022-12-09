using HetznerCloudApi.Objects.Universal;
using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.SshKey.Get
{
    public class Response
    {
        [JsonProperty("meta")]
        public Meta?Meta { get; set; }

        [JsonProperty("ssh_keys")]
        public List<Api.SshKey>? SshKeys { get; set; }
    }
}
