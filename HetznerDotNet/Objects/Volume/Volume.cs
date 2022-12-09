using Newtonsoft.Json;
using System;

namespace HetznerDotNet.Objects.Volume
{
    public class Protection
    {
        [JsonProperty("delete")]
        public bool? Delete { get; set; }
    }

    public class Volume
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("format")]
        public string? Format { get; set; }

        //[JsonProperty("labels")]
        //public Labels labels { get; set; }

        [JsonProperty("linux_device")]
        public string? LinuxDevice { get; set; }

        [JsonProperty("location")]
        public Api.Location? Location { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("protection")]
        public Protection? Protection { get; set; }

        [JsonProperty("server")]
        public long? Server { get; set; }

        [JsonProperty("size")]
        public long? Size { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}
