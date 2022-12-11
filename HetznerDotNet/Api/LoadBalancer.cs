using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class LoadBalancer : Objects.LoadBalancer.LoadBalancer
    {
        public static async Task<List<LoadBalancer>> Get()
        {
            List<LoadBalancer> list = new List<LoadBalancer>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.LoadBalancer.Get.Response response = JsonConvert.DeserializeObject<Objects.LoadBalancer.Get.Response>(await ApiCore.SendGetRequest($"/load_balancers?page={page}&per_page=25")) ?? new Objects.LoadBalancer.Get.Response();

                // Run
                foreach (LoadBalancer row in response.LoadBalancers)
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

        public static async Task<LoadBalancer> Get(long id)
        {
            // Get list
            Objects.LoadBalancer.GetOne.Response response = JsonConvert.DeserializeObject<Objects.LoadBalancer.GetOne.Response>(await ApiCore.SendGetRequest($"/load_balancers/{id}")) ?? new Objects.LoadBalancer.GetOne.Response();

            // Return
            return response.LoadBalancer;
        }

        public static async Task<LoadBalancer> Create(string name, int locationId, int size, Enum.eLoadBalancerAlgorithm loadBalancerAlgorithm)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{name}\",\"location\":{locationId},\"load_balancer_type\":{size},\"algorithm\":{{\"type\":\"{loadBalancerAlgorithm}\"}}}}";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/load_balancers", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<LoadBalancer>($"{result["load_balancer"]}") ?? new LoadBalancer();
        }

        public static async Task<LoadBalancer> Update(LoadBalancer loadBalancer)
        {
            // Preparing raw
            string rawSsh = $"{{\"name\":\"{loadBalancer.Name}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPutRequest($"/load_balancers/{loadBalancer.Id}", rawSsh);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<LoadBalancer>($"{result["load_balancer"]}") ?? new LoadBalancer();
        }

        public static async Task Delete(LoadBalancer loadBalancer)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/load_balancers/{loadBalancer.Id}");
        }
    }
}
