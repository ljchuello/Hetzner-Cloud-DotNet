using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination? Pagination { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("page")]
        public long? Page { get; set; }

        [JsonProperty("per_page")]
        public long? PerPage { get; set; }

        [JsonProperty("previous_page")]
        public long? PreviousPage { get; set; }

        [JsonProperty("next_page")]
        public long? NextPage { get; set; }

        [JsonProperty("last_page")]
        public long? LastPage { get; set; }

        [JsonProperty("total_entries")]
        public long? TotalEntries { get; set; }
    }
}
