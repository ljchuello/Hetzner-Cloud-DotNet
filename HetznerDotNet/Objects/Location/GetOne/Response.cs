using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Location.GetOne
{
    public class Response
    {
        [JsonProperty("location")]
        public Api.Location? Location { get; set; }
    }
}
