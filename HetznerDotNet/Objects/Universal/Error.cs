using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Universal
{
    [DataContract(Name = "error")]
    public class Error
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}