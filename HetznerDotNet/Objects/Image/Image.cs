using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Image
{
    public class Image
    {
        [JsonProperty("bound_to")]
        public object? bound_to { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset? created { get; set; }

        [JsonProperty("created_from")]
        public CreatedFrom? created_from { get; set; }

        [JsonProperty("deleted")]
        public object? deleted { get; set; }

        [JsonProperty("deprecated")]
        public DateTimeOffset? deprecated { get; set; }

        [JsonProperty("description")]
        public string? description { get; set; }

        [JsonProperty("disk_size")]
        public long? disk_size { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("image_size")]
        public double? image_size { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }

        [JsonProperty("os_flavor")]
        public string? os_flavor { get; set; }

        [JsonProperty("os_version")]
        public string? os_version { get; set; }

        //[JsonProperty("protection")]
        //public Protection protection { get; set; }

        [JsonProperty("rapid_deploy")]
        public bool? rapid_deploy { get; set; }

        [JsonProperty("status")]
        public string? status { get; set; }

        [JsonProperty("type")]
        public string? type { get; set; }
    }

    public class CreatedFrom
    {
        [JsonProperty("id")]
        public long? id { get; set; }

        [JsonProperty("name")]
        public string? name { get; set; }
    }

    //public class Protection
    //{
    //    [JsonProperty("delete")]
    //    public bool? delete { get; set; }
    //}
}
