using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Location.GetOne
{
    public class Response
    {
        [JsonProperty("location")]
        public Api.Location? location { get; set; }
    }
}
