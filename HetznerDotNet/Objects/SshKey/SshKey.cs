using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.SshKey
{
    public class SshKey
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("fingerprint")]
        public string? Fingerprint { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("public_key")]
        public string? PublicKey { get; set; }
    }
}
