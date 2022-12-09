using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
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