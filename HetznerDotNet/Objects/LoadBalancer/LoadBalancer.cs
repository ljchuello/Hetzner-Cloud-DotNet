using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.LoadBalancer
{
    public class Algorithm
    {
        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public class HealthCheck
    {
        [JsonProperty("http")]
        public Http? Http { get; set; }

        [JsonProperty("interval")]
        public long? Interval { get; set; }

        [JsonProperty("port")]
        public long? Port { get; set; }

        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("retries")]
        public long? Retries { get; set; }

        [JsonProperty("timeout")]
        public long? Timeout { get; set; }
    }

    public class HealthStatus
    {
        [JsonProperty("listen_port")]
        public long? ListenPort { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    public class Http
    {
        [JsonProperty("domain")]
        public string? Domain { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("response")]
        public string? Response { get; set; }

        [JsonProperty("status_codes")]
        public List<string>? StatusCodes { get; set; }

        [JsonProperty("tls")]
        public bool? Tls { get; set; }

        [JsonProperty("certificates")]
        public List<long>? Certificates { get; set; }

        [JsonProperty("cookie_lifetime")]
        public long? CookieLifetime { get; set; }

        [JsonProperty("cookie_name")]
        public string? CookieName { get; set; }

        [JsonProperty("redirect_http")]
        public bool? RedirectHttp { get; set; }

        [JsonProperty("sticky_sessions")]
        public bool? StickySessions { get; set; }
    }

    public class LabelSelector
    {
        [JsonProperty("selector")]
        public string? Selector { get; set; }
    }

    public class LoadBalancer
    {
        [JsonProperty("algorithm")]
        public Algorithm? Algorithm { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("included_traffic")]
        public long? IncludedTraffic { get; set; }

        [JsonProperty("ingoing_traffic")]
        public object? IngoingTraffic { get; set; }

        //[JsonProperty("labels")]
        //public Labels Labels { get; set; }

        [JsonProperty("load_balancer_type")]
        public LoadBalancerType LoadBalancerType { get; set; }

        [JsonProperty("location")]
        public Api.Location? Location { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("outgoing_traffic")]
        public object? OutgoingTraffic { get; set; }

        [JsonProperty("private_net")]
        public List<PrivateNet>? PrivateNet { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        [JsonProperty("public_net")]
        public PublicNet? PublicNet { get; set; }

        [JsonProperty("services")]
        public List<Service>? Services { get; set; }

        [JsonProperty("targets")]
        public List<Target>? Targets { get; set; }
    }

    public class LoadBalancerType
    {
        [JsonProperty("deprecated")]
        public DateTime? Deprecated { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("max_assigned_certificates")]
        public long? MaxAssignedCertificates { get; set; }

        [JsonProperty("max_connections")]
        public long? MaxConnections { get; set; }

        [JsonProperty("max_services")]
        public long? MaxServices { get; set; }

        [JsonProperty("max_targets")]
        public long? MaxTargets { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("prices")]
        public List<Api.Price>? Prices { get; set; }
    }

    public class PrivateNet
    {
        [JsonProperty("ip")]
        public string? Ip { get; set; }

        [JsonProperty("network")]
        public long? Network { get; set; }
    }

    public class Protection
    {
        [JsonProperty("delete")]
        public bool? Delete { get; set; }
    }

    public class PublicNet
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("ipv4")]
        public Universal.Ipv4? Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public Universal.Ipv6? Ipv6 { get; set; }
    }

    public class Root
    {
        [JsonProperty("load_balancer")]
        public LoadBalancer? LoadBalancer { get; set; }
    }

    public class Server
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Service
    {
        [JsonProperty("destination_port")]
        public long? DestinationPort { get; set; }

        [JsonProperty("health_check")]
        public HealthCheck? HealthCheck { get; set; }

        [JsonProperty("http")]
        public Http? Http { get; set; }

        [JsonProperty("listen_port")]
        public long? ListenPort { get; set; }

        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("proxyprotocol")]
        public bool? Proxyprotocol { get; set; }
    }

    public class Target
    {
        [JsonProperty("health_status")]
        public List<HealthStatus>? HealthStatus { get; set; }

        [JsonProperty("ip")]
        public Universal.Ip? Ip { get; set; }

        [JsonProperty("label_selector")]
        public LabelSelector? LabelSelector { get; set; }

        [JsonProperty("server")]
        public Server? Server { get; set; }

        [JsonProperty("targets")]
        public List<Target>? Targets { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("use_private_ip")]
        public bool? UsePrivateIp { get; set; }
    }
}
