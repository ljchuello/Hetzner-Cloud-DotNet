using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
{
    public class Action
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("command")]
        public string? Command { get; set; }

        [JsonProperty("error")]
        public Error? Error { get; set; }

        [JsonProperty("finished")]
        public DateTime? Finished { get; set; }

        [JsonProperty("progress")]
        public long? Progress { get; set; }

        [JsonProperty("resources")]
        public List<Resource>? Resources { get; set; }

        [JsonProperty("started")]
        public DateTime? Started { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    public class Resource
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
