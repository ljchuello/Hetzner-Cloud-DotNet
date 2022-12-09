using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerDotNet.Objects.SshKey.GetOne;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HetznerDotNet.Api
{
    public class SshKey : Objects.SshKey.SshKey
    {
        public static async Task<List<SshKey>> Get()
        {
            List<SshKey> listSshKeys = new List<SshKey>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.SshKey.Get.Response response = JsonConvert.DeserializeObject<Objects.SshKey.Get.Response>(await ApiCore.SendGetRequest($"/ssh_keys?page={page}&per_page=25")) ?? new HetznerDotNet.Objects.SshKey.Get.Response();

                // Run
                foreach (SshKey row in response.SshKeys)
                {
                    listSshKeys.Add(row);
                }

                // Finish?
                if (response.Meta.Pagination.NextPage == null)
                {
                    // Yes, finish
                    return listSshKeys;
                }
            }
        }

        public static async Task<SshKey> Get(long id)
        {
            // Get list
            Response response = JsonConvert.DeserializeObject<Response>(await ApiCore.SendGetRequest($"/ssh_keys/{id}")) ?? new Response();

            // Return
            return response.SshKey;
        }

        public static async Task<SshKey> Create(string sshName, string sshPublicKey)
        {
            // Preparing raw
            string rawSsh = $"{{\"name\":\"{sshName}\",\"public_key\":\"{sshPublicKey}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/ssh_keys", rawSsh);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<SshKey>($"{result["ssh_key"]}") ?? new SshKey();
        }

        public static async Task<SshKey> Update(SshKey sshKey)
        {
            // Preparing raw
            string rawSsh = $"{{\"name\":\"{sshKey.Name}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPutRequest($"/ssh_keys/{sshKey.Id}", rawSsh);
            
            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<SshKey>($"{result["ssh_key"]}") ?? new SshKey();
        }

        public static async Task Delete(SshKey sshKey)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/ssh_keys/{sshKey.Id}");
        }
    }
}
