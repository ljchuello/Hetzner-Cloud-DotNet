using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Image.GetOne
{
    public class Response
    {
        [JsonProperty("image")]
        public Api.Image? Image { get; set; }
    }
}
