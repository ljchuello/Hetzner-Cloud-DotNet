using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class Volume : Objects.Volume.Volume
    {
        /// <summary>
        /// List all volumes
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Volume>> Get()
        {
            List<Volume> list = new List<Volume>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.Volume.Get.Response response = JsonConvert.DeserializeObject<Objects.Volume.Get.Response>(await ApiCore.SendGetRequest($"/volumes?page={page}&per_page=25")) ?? new Objects.Volume.Get.Response();

                // Run
                foreach (Volume row in response.Volumes)
                {
                    list.Add(row);
                }

                // Finish?
                if (response.Meta.Pagination.NextPage == null)
                {
                    // Yes, finish
                    return list;
                }
            }
        }

        /// <summary>
        /// Get a volemune according to your id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Volume> Get(long id)
        {
            // Get list
            Objects.Volume.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Volume.GetOne.Response>(await ApiCore.SendGetRequest($"/volumes/{id}")) ?? new Objects.Volume.GetOne.Response();

            // Return
            return response.Volume;
        }

        /// <summary>
        /// Create a volume
        /// </summary>
        /// <param name="name">Volume name</param>
        /// <param name="size">Volume Size (in GiB)</param>
        /// <param name="format">Volume format (ext4 or xfs)</param>
        /// <param name="location">Region (fsn1, nbg1, hel1, ash, hil)</param>
        /// <returns></returns>
        public static async Task<Volume> Create(string name, int size, string format, string location)
        {
            // Preparing raw
            string raw = $"{{\"automount\":false,\"format\":\"{format}\",\"location\":\"{location}\",\"name\":\"{name}\",\"size\":{size:n0}}}";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/volumes", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Volume>($"{result["volume"]}") ?? new Volume();
        }

        /// <summary>
        /// Update a volume
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public static async Task<Volume> Update(Volume volume)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{volume.Name}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPutRequest($"/volumes/{volume.Id}", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Volume>($"{result["volume"]}") ?? new Volume();
        }

        /// <summary>
        /// Delete a volumen
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public static async Task Delete(Volume volume)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/volumes/{volume.Id}");
        }
    }
}
