using Newtonsoft.Json;
using System.Collections.Generic;

namespace HetznerDotNet.Objects.Universal
{
    public class Ip
    {
        [JsonProperty("ip")]
        public string IP { get; set; }
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
        public long? Id { get; set; }
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
        public long? Id { get; set; }
    }
}
