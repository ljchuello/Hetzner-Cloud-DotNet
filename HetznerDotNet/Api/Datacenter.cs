using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class Datacenter : Objects.Datacenter.Datacenter
    {
        public static async Task<List<Datacenter>> Get()
        {
            List<Datacenter> list = new List<Datacenter>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.Datacenter.Get.Response response = JsonConvert.DeserializeObject<Objects.Datacenter.Get.Response>(await ApiCore.SendGetRequest($"/datacenters?page={page}&per_page=25")) ?? new Objects.Datacenter.Get.Response();

                // Run
                foreach (Datacenter row in response.Datacenters)
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
        /// Get netwotk with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Datacenter> Get(long id)
        {
            // Get list
            Objects.Datacenter.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Datacenter.GetOne.Response>(await ApiCore.SendGetRequest($"/datacenters/{id}")) ?? new Objects.Datacenter.GetOne.Response();

            // Return
            return response.Datacenter;
        }
    }
}
