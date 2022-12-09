using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Network
{
    public class Network
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ip_range")]
        public string? IpRange { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("load_balancers")]
        public List<long>? LoadBalancers { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        [JsonProperty("routes")]
        public List<Route>? Routes { get; set; }

        [JsonProperty("servers")]
        public List<int>? Servers { get; set; }

        [JsonProperty("subnets")]
        public List<Subnet>? Subnets { get; set; }
    }

    public class Protection
    {
        [JsonProperty("delete")]
        public bool? Delete { get; set; }
    }

    public class Route
    {
        [JsonProperty("destination")]
        public string? Destination { get; set; }

        [JsonProperty("gateway")]
        public string? Gateway { get; set; }
    }

    public class Subnet
    {
        [JsonProperty("gateway")]
        public string? Gateway { get; set; }

        [JsonProperty("ip_range")]
        public string? IpRange { get; set; }

        [JsonProperty("network_zone")]
        public string? NetworkZone { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
