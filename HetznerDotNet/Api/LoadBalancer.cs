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

        public static async Task<LoadBalancer> Create(string name, long locationId, int size, Enum.eLoadBalancerAlgorithm loadBalancerAlgorithm)
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
            string raw = $"{{\"name\":\"{loadBalancer.Name}\"}}";

            // Send Put
            string jsonResponse = await ApiCore.SendPutRequest($"/load_balancers/{loadBalancer.Id}", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<LoadBalancer>($"{result["load_balancer"]}") ?? new LoadBalancer();
        }

        public static async Task Delete(LoadBalancer loadBalancer)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/load_balancers/{loadBalancer.Id}");
        }

        public class Network
        {
            public static async Task AttachToNetwork(LoadBalancer loadBalancer, long networkId, string privateIp = null)
            {
                // Preparing raw
                string raw = privateIp != null
                    ? $"{{\"network\":{networkId},\"ip\":\"{privateIp}\"}}"
                    : $"{{\"network\":{networkId}}}";

                // Send post
                await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/attach_to_network", raw);
            }

            public static async Task DetachFromNetwork(LoadBalancer loadBalancer, long networkId)
            {
                // Preparing raw
                string raw = $"{{\"network\":{networkId}}}";

                // Send post
                await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/detach_from_network", raw);
            }
        }

        public class Service
        {
            public static async Task Add(LoadBalancer loadBalancer, string protocol, long listenPort, long destinationPort, List<long> certificates = null, bool redirectHttpToHttps = false)
            {
                //List<long> asd = new List<long>();

                Objects.LoadBalancer.Service service = new Objects.LoadBalancer.Service();
                string raw;

                switch (protocol.ToLower())
                {
                    case "tcp":
                        // Servicio
                        service.Protocol = "tcp";
                        service.ListenPort = listenPort;
                        service.DestinationPort = destinationPort;
                        service.Proxyprotocol = false;
                        service.Http = null;

                        // Health check
                        service.HealthCheck = new Objects.LoadBalancer.HealthCheck();
                        service.HealthCheck.Protocol = "tcp";
                        service.HealthCheck.Port = destinationPort;
                        service.HealthCheck.Interval = 15;
                        service.HealthCheck.Timeout = 10;
                        service.HealthCheck.Retries = 3;

                        // Preparing raw
                        raw = JsonConvert.SerializeObject(service, Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                        // Send post
                        await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/add_service", raw);
                        return;

                    case "http":
                        // Servicio
                        service.Protocol = "http";
                        service.ListenPort = listenPort;
                        service.DestinationPort = destinationPort;
                        service.Proxyprotocol = false;

                        // Http
                        service.Http = new Objects.LoadBalancer.Http();
                        service.Http.CookieName = "HCLBSTICKY";
                        service.Http.CookieLifetime = 300;
                        service.Http.RedirectHttp = redirectHttpToHttps;
                        service.Http.StickySessions = false;

                        // Health check
                        service.HealthCheck = new Objects.LoadBalancer.HealthCheck();
                        service.HealthCheck.Protocol = "http";
                        service.HealthCheck.Port = destinationPort;
                        service.HealthCheck.Interval = 15;
                        service.HealthCheck.Timeout = 10;
                        service.HealthCheck.Retries = 3;
                        service.Http.Path = "/";
                        service.Http.StatusCodes = new List<string>
                        {
                            "2??",
                            "3??",
                        };
                        service.Http.Tls = false;

                        // Preparing raw
                        raw = JsonConvert.SerializeObject(service, Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                        // Send post
                        await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/add_service", raw);
                        return;

                    case "https":
                        // Servicio
                        service.Protocol = "https";
                        service.ListenPort = listenPort;
                        service.DestinationPort = destinationPort;
                        service.Proxyprotocol = false;

                        // Http
                        service.Http = new Objects.LoadBalancer.Http();
                        service.Http.CookieName = "HCLBSTICKY";
                        service.Http.CookieLifetime = 300;
                        service.Http.RedirectHttp = redirectHttpToHttps;
                        service.Http.StickySessions = false;
                        service.Http.Certificates = certificates;

                        // Health check
                        service.HealthCheck = new Objects.LoadBalancer.HealthCheck();
                        service.HealthCheck.Protocol = "http";
                        service.HealthCheck.Port = destinationPort;
                        service.HealthCheck.Interval = 15;
                        service.HealthCheck.Timeout = 10;
                        service.HealthCheck.Retries = 3;
                        service.HealthCheck.Http = new Objects.LoadBalancer.Http();
                        service.HealthCheck.Http.Path = "/";
                        service.HealthCheck.Http.StatusCodes = new List<string>
                        {
                            "2??",
                            "3??",
                        };
                        service.HealthCheck.Http.Tls = false;

                        // Preparing raw
                        raw = JsonConvert.SerializeObject(service, Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

                        // Send post
                        await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/add_service", raw);
                        return;
                }
            }

            public static async Task Remove(LoadBalancer loadBalancer, long listenPort)
            {
                // Preparing raw
                string raw = $"{{\"listen_port\":{listenPort}}}";

                // Send post
                await ApiCore.SendPostRequest($"/load_balancers/{loadBalancer.Id}/actions/delete_service", raw);
            }
        }

        public class Target
        {
            public static async Task Add(LoadBalancer loadBalancer, long serverId, bool usePrivateIp = false)
            {
                string raw = $"{{\"attachments\":[{{\"server\":{{\"id\":{serverId}}},\"use_private_ip\":{(usePrivateIp ? "true" : "false")},\"type\":\"server\"}}]}}";
                
                // Send
                await ApiCore.SendPutRequest($"/load_balancers/{loadBalancer.Id}/_add_targets", raw);
            }

            public static async Task Remove(LoadBalancer loadBalancer, long serverId)
            {
                string raw = $"{{\"attachments\":[{{\"server\":{{\"id\":{serverId}}},\"type\":\"server\"}}]}}";

                // Send
                await ApiCore.SendPutRequest($"/load_balancers/{loadBalancer.Id}/_remove_targets", raw);
            }
        }
    }
}
