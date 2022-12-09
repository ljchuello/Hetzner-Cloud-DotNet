using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.ServerType
{
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

        //[JsonProperty("deprecated")]
        //public object deprecated { get; set; }

        [JsonProperty("prices")]
        public List<Price>? Prices { get; set; }

        [JsonProperty("storage_type")]
        public string? StorageType { get; set; }

        [JsonProperty("cpu_type")]
        public string? CpuType { get; set; }
    }
}
