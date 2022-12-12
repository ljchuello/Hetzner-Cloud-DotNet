using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerDotNet.Objects.Location.GetOne;
using Newtonsoft.Json;

namespace HetznerDotNet.Api
{
    public class Location : Objects.Location.Location
    {
        /// <summary>
        /// Get all locations
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Location>> Get()
        {
            // Get list
            Objects.Location.Get.Response response = JsonConvert.DeserializeObject<Objects.Location.Get.Response>(await ApiCore.SendGetRequest("/locations")) ?? new Objects.Location.Get.Response();
            
            // Run
            List<Location> locations = new List<Location>();
            foreach (Location row in response.Locations)
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
            return response.Location;
        }
    }
}
