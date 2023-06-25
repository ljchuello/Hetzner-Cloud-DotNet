using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.ServerType
{
    public class Price
    {
        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("price_hourly")]
        public PriceHourly? Price_hourly { get; set; }

        [JsonProperty("price_monthly")]
        public PriceMonthly? Price_monthly { get; set; }
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

    public class ServerType
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("cores")]
        public int? Cores { get; set; }

        [JsonProperty("memory")]
        public double? Memory { get; set; }

        [JsonProperty("disk")]
        public int? Disk { get; set; }

        //[JsonProperty("deprecated")]
        //public object deprecated { get; set; }

        [JsonProperty("prices")]
        public List<Price>? Prices { get; set; }

        [JsonProperty("storage_type")]
        public string? Storage_type { get; set; }

        [JsonProperty("cpu_type")]
        public string? Cpu_type { get; set; }

        [JsonProperty("architecture")]
        public string? Architecture { get; set; }
    }
}
