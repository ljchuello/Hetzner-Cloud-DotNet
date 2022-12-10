using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Price
{
    public class PriceHourly
    {
        [JsonProperty("gross")]
        public string Gross { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }
    }

    public class PriceMonthly
    {
        [JsonProperty("gross")]
        public string Gross { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }
    }

    public class Price
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("price_hourly")]
        public PriceHourly PriceHourly { get; set; }

        [JsonProperty("price_monthly")]
        public PriceMonthly PriceMonthly { get; set; }
    }
}
