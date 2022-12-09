using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerDotNet.Objects.ServerType.GetOne;
using Newtonsoft.Json;

namespace HetznerDotNet.Api
{
    public class ServerType : HetznerDotNet.Objects.ServerType.ServerType
    {
        public static async Task<List<ServerType>> Get()
        {
            List<ServerType> listServerType = new List<ServerType>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                HetznerDotNet.Objects.ServerType.Get.Response response = JsonConvert.DeserializeObject<HetznerDotNet.Objects.ServerType.Get.Response>(await ApiCore.SendGetRequest($"/server_types?page={page}&per_page=25")) ?? new HetznerDotNet.Objects.ServerType.Get.Response();

                // Run
                foreach (ServerType row in response.ServerTypes)
                {
                    listServerType.Add(row);
                }

                // Finish?
                if (response.Meta.Pagination.NextPage == null)
                {
                    // Yes, finish
                    return listServerType;
                }
            }
        }

        public static async Task<ServerType> Get(long id)
        {
            // Get list
            Response response = JsonConvert.DeserializeObject<Response>(await ApiCore.SendGetRequest($"/server_types/{id}")) ?? new Response();

            // Return
            return response.ServerType;
        }
    }
}
