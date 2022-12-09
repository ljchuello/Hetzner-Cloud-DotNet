using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination? pagination { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("page")]
        public long? page { get; set; }

        [JsonProperty("per_page")]
        public long? per_page { get; set; }

        [JsonProperty("previous_page")]
        public long? previous_page { get; set; }

        [JsonProperty("next_page")]
        public long? next_page { get; set; }

        [JsonProperty("last_page")]
        public long? last_page { get; set; }

        [JsonProperty("total_entries")]
        public long? total_entries { get; set; }
    }
}
