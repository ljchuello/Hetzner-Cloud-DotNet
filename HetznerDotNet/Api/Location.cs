using Newtonsoft.Json;

namespace HetznerCloudApi.Api
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
            Objects.Location.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Location.GetOne.Response>(await ApiCore.SendGetRequest($"/locations/{id}")) ?? new Objects.Location.GetOne.Response();

            // Return
            return response.location;
        }
    }
}
