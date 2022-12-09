using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Volume.GetOne
{
    public class Response
    {
        [JsonProperty("volume")]
        public Api.Volume Volume { get; set; }
    }
}
