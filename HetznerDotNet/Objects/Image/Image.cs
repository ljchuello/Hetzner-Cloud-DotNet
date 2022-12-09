using System;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Image
{
    public class CreatedFrom
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class Image
    {
        [JsonProperty("bound_to")]
        public object? BoundTo { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("created_from")]
        public CreatedFrom? CreatedFrom { get; set; }

        [JsonProperty("deleted")]
        public object? Deleted { get; set; }

        [JsonProperty("deprecated")]
        public DateTime? Deprecated { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("disk_size")]
        public long? DiskSize { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("image_size")]
        public double? ImageSize { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("os_flavor")]
        public string? OsFlavor { get; set; }

        [JsonProperty("os_version")]
        public string? OsVersion { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        [JsonProperty("rapid_deploy")]
        public bool? RapidDeploy { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public class Protection
    {
        [JsonProperty("delete")]
        public bool? Delete { get; set; }
    }
}
