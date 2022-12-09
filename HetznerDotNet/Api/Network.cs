using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace HetznerCloudApi.Api
{
    public class Network : Objects.Network.Network
    {
        public static async Task<Network> Create(string ipRange, string sshPublicKey)
        {
            // Preparing raw
            string rawSsh = $"\"{{\\\"ip_range\\\":\\\"{ipRange}\\\",\\\"labels\\\":{{\\\"labelkey\\\":\\\"value\\\"}},\\\"name\\\":\\\"mynet\\\",\\\"routes\\\":[{{\\\"destination\\\":\\\"10.100.1.0/24\\\",\\\"gateway\\\":\\\"10.0.1.1\\\"}}],\\\"subnets\\\":[{{\\\"ip_range\\\":\\\"10.0.1.0/24\\\",\\\"network_zone\\\":\\\"eu-central\\\",\\\"type\\\":\\\"cloud\\\"}}]}}\"";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/ssh_keys", rawSsh);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<Network>($"{result["ssh_key"]}") ?? new Network();
        }
    }
}
