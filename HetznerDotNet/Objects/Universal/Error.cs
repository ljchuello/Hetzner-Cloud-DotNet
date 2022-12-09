using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HetznerCloudApi.Objects.Universal
{
    [DataContract(Name = "error")]
    public class Error
    {
        [JsonProperty("code")]
        public string? code { get; set; }

        [JsonProperty("message")]
        public string? message { get; set; }
    }
}