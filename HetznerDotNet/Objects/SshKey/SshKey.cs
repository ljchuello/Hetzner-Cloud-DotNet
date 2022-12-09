using System;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.SshKey
{
    public class SshKey
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("fingerprint")]
        public string? Fingerprint { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("public_key")]
        public string? PublicKey { get; set; }
    }
}
