using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace HetznerDotNet.Objects.Firewall
{
    public class AppliedTo
    {
        [JsonProperty("applied_to_resources")]
        public List<AppliedToResource> AppliedToResources { get; set; }

        [JsonProperty("label_selector")]
        public LabelSelector LabelSelector { get; set; }

        [JsonProperty("server")]
        public Server Server { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AppliedToResource
    {
        [JsonProperty("server")]
        public Server Server { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Firewall
    {
        [JsonProperty("applied_to")]
        public List<AppliedTo> AppliedTo { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }
    }

    public class LabelSelector
    {
        [JsonProperty("selector")]
        public string Selector { get; set; }
    }

    public class Rule
    {
        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("destination_ips")]
        public List<string> DestinationIps { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("source_ips")]
        public List<string> SourceIps { get; set; }
    }

    public class Server
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
