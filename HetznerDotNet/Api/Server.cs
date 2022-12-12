using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class Server : Objects.Server.Server
    {
        public static async Task<List<Server>> Get()
        {
            List<Server> list = new List<Server>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.Server.Get.Response response = JsonConvert.DeserializeObject<Objects.Server.Get.Response>(await ApiCore.SendGetRequest($"/servers?page={page}&per_page=25")) ?? new Objects.Server.Get.Response();

                // Run
                foreach (Server row in response.Servers)
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

        public static async Task<Server> Get(long id)
        {
            // Get list
            Objects.Server.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Server.GetOne.Response>(await ApiCore.SendGetRequest($"/servers/{id}")) ?? new Objects.Server.GetOne.Response();

            // Return
            return response.Server;
        }

        public static async Task<Server> Update(Server server)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{server.Name}\"}}";

            // Send Put
            string jsonResponse = await ApiCore.SendPutRequest($"/servers/{server.Id}", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Server>($"{result["server"]}") ?? new Server();
        }

        public static async Task Delete(Server server)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/servers/{server.Id}");
        }
    }
}
