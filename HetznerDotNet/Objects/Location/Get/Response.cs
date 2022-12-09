using System.Collections.Generic;
using Newtonsoft.Json;

namespace HetznerDotNet.Objects.Location.Get
{
    public class Response
    {
        [JsonProperty("locations")]
        public List<Api.Location>? Locations { get; set; }
    }
}
