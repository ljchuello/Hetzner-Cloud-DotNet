using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
{
    public class Ip
    {
        [JsonProperty("ip")]
        public string IP { get; set; }
    }

    public class Ipv4
    {
        [JsonProperty("dns_ptr")]
        public string DnsPtr { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }
    }

    public class Ipv6
    {
        [JsonProperty("dns_ptr")]
        public string DnsPtr { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }
    }
}
