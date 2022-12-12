using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Server
{
    public class Firewall
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    //public class Ipv4
    //{
    //    [JsonProperty("ip")]
    //    public string? Ip { get; set; }

    //    [JsonProperty("blocked")]
    //    public bool? Blocked { get; set; }

    //    [JsonProperty("dns_ptr")]
    //    public string? DnsPtr { get; set; }

    //    [JsonProperty("id")]
    //    public long Id { get; set; }
    //}

    //public class Ipv6
    //{
    //    [JsonProperty("ip")]
    //    public string? Ip { get; set; }

    //    [JsonProperty("blocked")]
    //    public bool? Blocked { get; set; }

    //    [JsonProperty("dns_ptr")]
    //    public List<string>? DnsPtr { get; set; }

    //    [JsonProperty("id")]
    //    public long Id { get; set; }
    //}

    public class PrivateNet
    {
        [JsonProperty("network")]
        public long? Network { get; set; }

        [JsonProperty("ip")]
        public string? Ip { get; set; }

        [JsonProperty("alias_ips")]
        public List<object>? AliasIps { get; set; }

        [JsonProperty("mac_address")]
        public string? MacAddress { get; set; }
    }

    public class Protection
    {
        [JsonProperty("delete")]
        public bool? Delete { get; set; }

        [JsonProperty("rebuild")]
        public bool? Rebuild { get; set; }
    }

    public class PublicNet
    {
        [JsonProperty("ipv4")]
        public Universal.Ipv4? Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public Universal.Ipv6? Ipv6 { get; set; }

        [JsonProperty("floating_ips")]
        public List<int>? FloatingIps { get; set; }

        [JsonProperty("firewalls")]
        public List<Firewall>? Firewalls { get; set; }
    }

    public class Server
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("public_net")]
        public PublicNet? PublicNet { get; set; }

        [JsonProperty("private_net")]
        public List<PrivateNet>? PrivateNet { get; set; }

        [JsonProperty("server_type")]
        public Api.ServerType? ServerType { get; set; }

        [JsonProperty("datacenter")]
        public Api.Datacenter Datacenter { get; set; }

        [JsonProperty("image")]
        public Api.Image? Image { get; set; }

        [JsonProperty("iso")]
        public object? Iso { get; set; }

        [JsonProperty("rescue_enabled")]
        public bool? RescueEnabled { get; set; }

        [JsonProperty("locked")]
        public bool? Locked { get; set; }

        [JsonProperty("backup_window")]
        public object? BackupWindow { get; set; }

        [JsonProperty("outgoing_traffic")]
        public object? OutgoingTraffic { get; set; }

        [JsonProperty("ingoing_traffic")]
        public object? IngoingTraffic { get; set; }

        [JsonProperty("included_traffic")]
        public long? IncludedTraffic { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        //[JsonProperty("labels")]
        //public Labels Labels { get; set; }

        [JsonProperty("volumes")]
        public List<int>? Volumes { get; set; }

        [JsonProperty("load_balancers")]
        public List<int>? LoadBalancers { get; set; }

        [JsonProperty("primary_disk_size")]
        public long? PrimaryDiskSize { get; set; }

        [JsonProperty("placement_group")]
        public Api.PlacementGroup? PlacementGroup { get; set; }
    }
}
