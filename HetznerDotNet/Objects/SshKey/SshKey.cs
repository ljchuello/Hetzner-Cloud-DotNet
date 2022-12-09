using System;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.SshKey
{
    public class SshKey
    {
        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("created")]
        public DateTime? created { get; set; }

        [JsonProperty("fingerprint")]
        public string? fingerprint { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }

        [JsonProperty("public_key")]
        public string? public_key { get; set; }
    }
}
