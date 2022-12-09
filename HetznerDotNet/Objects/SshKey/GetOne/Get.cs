using Newtonsoft.Json;

namespace HetznerDotNet.Objects.SshKey.GetOne
{
    public class Response
    {
        [JsonProperty("ssh_key")]
        public Api.SshKey? sshKey { get; set; }
    }
}
