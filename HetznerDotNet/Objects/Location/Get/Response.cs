using Newtonsoft.Json;

namespace HetznerCloudApi.Objects.Location.Get
{
    public class Response
    {
        [JsonProperty("locations")]
        public List<Api.Location>? locations { get; set; }
    }
}
