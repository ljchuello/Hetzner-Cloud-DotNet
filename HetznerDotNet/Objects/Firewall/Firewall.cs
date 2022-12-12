using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace HetznerDotNet.Objects.Firewall
{
    public class AppliedTo
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("server")]
        public Server? Server { get; set; }
    }

    public class Firewall
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        //[JsonProperty("labels")]
        //public Labels Labels { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("rules")]
        public List<Rule>? Rules { get; set; }

        [JsonProperty("applied_to")]
        public List<AppliedTo>? AppliedTo { get; set; }
    }

    public class Rule
    {
        [JsonProperty("direction")]
        public string? Direction { get; set; }

        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("port")]
        public string? Port { get; set; }

        [JsonProperty("source_ips")]
        public List<string>? SourceIps { get; set; }

        [JsonProperty("destination_ips")]
        public List<string>? DestinationIps { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }

    public class Server
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
