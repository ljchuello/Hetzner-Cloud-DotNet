namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            try
            {
                // Tools - Generate Real SSH Pri/Pub
                SshKeyGenerator.SshKeyGenerator sshKeyGenerator = new SshKeyGenerator.SshKeyGenerator(2048);
                string clave = sshKeyGenerator.ToPrivateKey();
                string valor = sshKeyGenerator.ToRfcPublicKey();

                // Token
                ApiCore.ApiToken = "W1FjKPy3XAReWPGTbxuwteLrjZzi4wxUIJMZL4dcPF91ENhYfJTv4YiPRvtMtJtu";

                //// Location
                //var locationList = await HetznerCloudApi.Api.Location.Get();
                //var location = await HetznerCloudApi.Api.Location.Get(locationList[0].id);

                //// SshKey
                //HetznerCloudApi.Api.SshKey sshKeyAdd = await HetznerCloudApi.Api.SshKey.Create($"TEST - {Guid.NewGuid()}", valor);
                //sshKeyAdd.Name = $"Test - {Guid.NewGuid()}";
                //HetznerCloudApi.Api.SshKey sshkeUpdate = await HetznerCloudApi.Api.SshKey.Update(sshKeyAdd);
                //HetznerCloudApi.Api.SshKey sshKeyGetOne = await HetznerCloudApi.Api.SshKey.Get(sshKeyAdd.Id);
                //List<HetznerCloudApi.Api.SshKey> sshKeyGetAll = await HetznerCloudApi.Api.SshKey.Get();
                //await HetznerCloudApi.Api.SshKey.Delete(new HetznerCloudApi.Api.SshKey());

                //// Images
                //List<HetznerCloudApi.Api.Image> listImage = await HetznerCloudApi.Api.Image.Get();
                //HetznerCloudApi.Api.Image image = await HetznerCloudApi.Api.Image.Get(listImage[15].id);

                //// ServerType
                //List<HetznerCloudApi.Api.ServerType> listServerType = await HetznerCloudApi.Api.ServerType.Get();
                //HetznerCloudApi.Api.ServerType serverType = await HetznerCloudApi.Api.ServerType.Get(listServerType[0].id);

                // Network
                //HetznerCloudApi.Api.Network networkAdd = await HetznerCloudApi.Api.Network.Create($"Prueba", "192.168.0.0/16");
                //List<HetznerCloudApi.Api.Network> listNetwork = await HetznerCloudApi.Api.Network.Get();
                //HetznerCloudApi.Api.Network network = await HetznerCloudApi.Api.Network.Get(2282516);
                //listNetwork[0].name = $"TEST - EDIT - {Guid.NewGuid()}";
                //HetznerCloudApi.Api.Network networkUpdate = await HetznerCloudApi.Api.Network.Update(listNetwork[0]);
                //await HetznerCloudApi.Api.Network.Delete(listNetwork[0]);

                // Network - Subnet's
                //await HetznerCloudApi.Api.Network.SubnetCreate(network, "192.168.0.0/16", "eu-central");
                //await HetznerCloudApi.Api.Network.SubnetDelete(network, "192.168.0.0/16");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}