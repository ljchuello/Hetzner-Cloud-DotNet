using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Server
{
    public class Datacenter
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("location")]
        public Location? Location { get; set; }

        [JsonProperty("server_types")]
        public ServerTypes? ServerTypes { get; set; }
    }

    public class Firewall
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    public class Image
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("image_size")]
        public object? ImageSize { get; set; }

        [JsonProperty("disk_size")]
        public long? DiskSize { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("created_from")]
        public object? CreatedFrom { get; set; }

        [JsonProperty("bound_to")]
        public object? BoundTo { get; set; }

        [JsonProperty("os_flavor")]
        public string? OsFlavor { get; set; }

        [JsonProperty("os_version")]
        public string? OsVersion { get; set; }

        [JsonProperty("rapid_deploy")]
        public bool? RapidDeploy { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        [JsonProperty("deprecated")]
        public object? Deprecated { get; set; }

        //[JsonProperty("labels")]
        //public Labels Labels { get; set; }

        [JsonProperty("deleted")]
        public object? Deleted { get; set; }
    }

    public class Ipv4
    {
        [JsonProperty("ip")]
        public string? Ip { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("dns_ptr")]
        public string? DnsPtr { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public class Ipv6
    {
        [JsonProperty("ip")]
        public string? Ip { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("dns_ptr")]
        public List<string>? DnsPtr { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("network_zone")]
        public string? NetworkZone { get; set; }
    }

    public class PlacementGroup
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        //[JsonProperty("labels")]
        //public Labels Labels { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("servers")]
        public List<int>? Servers { get; set; }
    }

    public class Price
    {
        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("price_hourly")]
        public PriceHourly? PriceHourly { get; set; }

        [JsonProperty("price_monthly")]
        public PriceMonthly? PriceMonthly { get; set; }
    }

    public class PriceHourly
    {
        [JsonProperty("net")]
        public string? Net { get; set; }

        [JsonProperty("gross")]
        public string? Gross { get; set; }
    }

    public class PriceMonthly
    {
        [JsonProperty("net")]
        public string? Net { get; set; }

        [JsonProperty("gross")]
        public string? Gross { get; set; }
    }

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
        public Ipv4? Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public Ipv6? Ipv6 { get; set; }

        [JsonProperty("floating_ips")]
        public List<int>? FloatingIps { get; set; }

        [JsonProperty("firewalls")]
        public List<Firewall>? Firewalls { get; set; }
    }

    public class Root
    {
        [JsonProperty("server")]
        public Server? Server { get; set; }
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
        public ServerType? ServerType { get; set; }

        [JsonProperty("datacenter")]
        public Datacenter Datacenter { get; set; }

        [JsonProperty("image")]
        public Image? Image { get; set; }

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
        public PlacementGroup? PlacementGroup { get; set; }
    }

    public class ServerType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("cores")]
        public long? Cores { get; set; }

        [JsonProperty("memory")]
        public double? Memory { get; set; }

        [JsonProperty("disk")]
        public long? Disk { get; set; }

        [JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }

        [JsonProperty("prices")]
        public List<Price>? Prices { get; set; }

        [JsonProperty("storage_type")]
        public string? StorageType { get; set; }

        [JsonProperty("cpu_type")]
        public string? CpuType { get; set; }
    }

    public class ServerTypes
    {
        [JsonProperty("supported")]
        public List<int>? Supported { get; set; }

        [JsonProperty("available")]
        public List<int>? Available { get; set; }

        [JsonProperty("available_for_migration")]
        public List<int>? AvailableForMigration { get; set; }
    }
}
