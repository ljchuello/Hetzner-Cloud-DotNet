using Newtonsoft.Json;

namespace HetznerCloudApi.Api
{
    public class ServerType : Objects.ServerType.ServerType
    {
        public static async Task<List<ServerType>> Get()
        {
            List<ServerType> listServerType = new List<ServerType>();
            int page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.ServerType.Get.Response response = JsonConvert.DeserializeObject<Objects.ServerType.Get.Response>(await ApiCore.SendGetRequest($"/server_types?page={page}&per_page=25")) ?? new Objects.ServerType.Get.Response();

                // Run
                foreach (ServerType row in response.server_types)
                {
                    listServerType.Add(row);
                }

                // Finish?
                if (response.meta.pagination.next_page == null)
                {
                    // Yes, finish
                    return listServerType;
                }
            }
        }

        public static async Task<ServerType> Get(long id)
        {
            // Get list
            Objects.ServerType.GetOne.Response response = JsonConvert.DeserializeObject<Objects.ServerType.GetOne.Response>(await ApiCore.SendGetRequest($"/server_types/{id}")) ?? new Objects.ServerType.GetOne.Response();

            // Return
            return response.server_type;
        }
    }
}
