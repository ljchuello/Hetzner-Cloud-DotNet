using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.SshKey.GetOne
{
    public class Response
    {
        [JsonProperty("ssh_key")]
        public Api.SshKey? SshKey { get; set; }
    }
}
