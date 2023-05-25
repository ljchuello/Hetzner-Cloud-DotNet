using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class Firewall : Objects.Firewall.Firewall
    {
        public static async Task<List<Firewall>> Get()
        {
            List<Firewall> list = new List<Firewall>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.Firewall.Get.Response response = JsonConvert.DeserializeObject<Objects.Firewall.Get.Response>(await ApiCore.SendGetRequest($"/firewalls?page={page}&per_page=25")) ?? new Objects.Firewall.Get.Response();

                // Run
                foreach (Firewall row in response.Firewalls)
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

        public static async Task<Firewall> Get(long id)
        {
            // Get list
            Objects.Firewall.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Firewall.GetOne.Response>(await ApiCore.SendGetRequest($"/firewalls/{id}")) ?? new Objects.Firewall.GetOne.Response();

            // Return
            return response.Firewall;
        }

        public static async Task<Firewall> Create(string name)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{name}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/firewalls", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Firewall>($"{result["firewall"]}") ?? new Firewall();
        }

        public static async Task<Firewall> Update(Firewall firewall)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{firewall.Name}\"}}";

            // Send Put
            string jsonResponse = await ApiCore.SendPutRequest($"/firewalls/{firewall.Id}", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Firewall>($"{result["firewall"]}") ?? new Firewall();
        }

        public static async Task Delete(Firewall loadBalancer)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/firewalls/{loadBalancer.Id}");
        }

        public class Rule : Objects.Firewall.Rule
        {
            public static async Task SetRules(Firewall loadBalancer, List<Rule> rules)
            {
                var temp = new
                {
                    rules = rules
                };

                // Raw
                string json = JsonConvert.SerializeObject(temp, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                // Send post
                await ApiCore.SendPostRequest($"/firewalls/{loadBalancer.Id}/actions/set_rules", json);
            }
        }

        public class Targe
        {
            public static async Task Add(Firewall firewall, long serverId)
            {
                // Preparing raw
                string raw = $"{{\"apply_to\":[{{\"server\":{{\"id\":{serverId}}},\"type\":\"server\"}}]}}";

                // Send Put
                await ApiCore.SendPostRequest($"/firewalls/{firewall.Id}/actions/apply_to_resources", raw);
            }

            public static async Task Remove(Firewall firewall, long serverId)
            {
                // Preparing raw
                string raw = $"{{\"remove_from\":[{{\"server\":{{\"id\":{serverId}}},\"type\":\"server\"}}]}}";

                // Send Put
                await ApiCore.SendPostRequest($"/firewalls/{firewall.Id}/actions/remove_from_resources", raw);
            }
        }
    }
}
