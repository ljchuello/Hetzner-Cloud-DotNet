using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Image.GetOne
{
    public class Response
    {
        [JsonProperty("image")]
        public Api.Image? image { get; set; }
    }
}
