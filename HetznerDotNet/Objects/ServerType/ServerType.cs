﻿using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.ServerType
{
    public class Price
    {
        [JsonProperty("location")]
        public string? location { get; set; }

        [JsonProperty("price_hourly")]
        public PriceHourly? price_hourly { get; set; }

        [JsonProperty("price_monthly")]
        public PriceMonthly? price_monthly { get; set; }
    }

    public class PriceHourly
    {
        [JsonProperty("net")]
        public string? net { get; set; }

        [JsonProperty("gross")]
        public string? gross { get; set; }
    }

    public class PriceMonthly
    {
        [JsonProperty("net")]
        public string? net { get; set; }

        [JsonProperty("gross")]
        public string? gross { get; set; }
    }

    public class ServerType
    {
        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }

        [JsonProperty("description")]
        public string? description { get; set; }

        [JsonProperty("cores")]
        public long? cores { get; set; }

        [JsonProperty("memory")]
        public double? memory { get; set; }

        [JsonProperty("disk")]
        public long? disk { get; set; }

        //[JsonProperty("deprecated")]
        //public object deprecated { get; set; }

        [JsonProperty("prices")]
        public List<Price>? prices { get; set; }

        [JsonProperty("storage_type")]
        public string? storage_type { get; set; }

        [JsonProperty("cpu_type")]
        public string? cpu_type { get; set; }
    }
}
