using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerDotNet.Objects.Location.GetOne;
using Newtonsoft.Json;

namespace HetznerDotNet.Api
{
    public class Location : HetznerDotNet.Objects.Location.Location
    {
        /// <summary>
        /// Get all locations
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Location>> Get()
        {
            // Get list
            HetznerDotNet.Objects.Location.Get.Response response = JsonConvert.DeserializeObject<HetznerDotNet.Objects.Location.Get.Response>(await ApiCore.SendGetRequest("/locations")) ?? new HetznerDotNet.Objects.Location.Get.Response();
            
            // Run
            List<Location> locations = new List<Location>();
            foreach (Location row in response.locations)
            {
                locations.Add(row);
            }

            return locations;
        }

        /// <summary>
        /// Gets a location according to the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Location> Get(long id)
        {
            // Get list
            Response response = JsonConvert.DeserializeObject<Response>(await ApiCore.SendGetRequest($"/locations/{id}")) ?? new Response();

            // Return
            return response.location;
        }
    }
}
