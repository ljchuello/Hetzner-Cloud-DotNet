using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Network
{
    public class Network
    {
        [JsonProperty("created")]
        public DateTime? created { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("ip_range")]
        public string? ip_range { get; set; }

        [JsonProperty("load_balancers")]
        public List<long?> load_balancers { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }

        //[JsonProperty("protection")]
        //public Protection protection { get; set; }

        //[JsonProperty("routes")]
        //public List<Route> routes { get; set; }

        [JsonProperty("servers")]
        public List<long?>? servers { get; set; }

        [JsonProperty("subnets")]
        public List<Subnet>? subnets { get; set; }
    }

    //public class Route
    //{
    //    [JsonProperty("destination")]
    //    public string destination { get; set; }

    //    [JsonProperty("gateway")]
    //    public string gateway { get; set; }
    //}

    public class Subnet
    {
        [JsonProperty("gateway")]
        public string? gateway { get; set; }

        [JsonProperty("ip_range")]
        public string? ip_range { get; set; }

        [JsonProperty("network_zone")]
        public string? network_zone { get; set; }

        [JsonProperty("type")]
        public string? type { get; set; }
    }
}
