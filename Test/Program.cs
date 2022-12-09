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
                HetznerDotNet.ApiCore.ApiToken = "W1FjKPy3XAReWPGTbxuwteLrjZzi4wxUIJMZL4dcPF91ENhYfJTv4YiPRvtMtJtu";

                // Location
                var locationList = await HetznerDotNet.Api.Location.Get();
                var location = await HetznerDotNet.Api.Location.Get(locationList[0].id);

                // SshKey
                HetznerDotNet.Api.SshKey sshKeyAdd = await HetznerDotNet.Api.SshKey.Create($"TEST - {Guid.NewGuid()}", valor);
                sshKeyAdd.Name = $"Test - {Guid.NewGuid()}";
                HetznerDotNet.Api.SshKey sshkeUpdate = await HetznerDotNet.Api.SshKey.Update(sshKeyAdd);
                HetznerDotNet.Api.SshKey sshKeyGetOne = await HetznerDotNet.Api.SshKey.Get(sshKeyAdd.Id);
                List<HetznerDotNet.Api.SshKey> sshKeyGetAll = await HetznerDotNet.Api.SshKey.Get();
                await HetznerDotNet.Api.SshKey.Delete(new HetznerDotNet.Api.SshKey());

                // Images
                List<HetznerDotNet.Api.Image> listImage = await HetznerDotNet.Api.Image.Get();
                HetznerDotNet.Api.Image image = await HetznerDotNet.Api.Image.Get(listImage[15].id);

                // ServerType
                List<HetznerDotNet.Api.ServerType> listServerType = await HetznerDotNet.Api.ServerType.Get();
                HetznerDotNet.Api.ServerType serverType = await HetznerDotNet.Api.ServerType.Get(listServerType[0].id);

                // Network
                HetznerDotNet.Api.Network networkAdd = await HetznerDotNet.Api.Network.Create($"Prueba", "192.168.0.0/16");
                List<HetznerDotNet.Api.Network> listNetwork = await HetznerDotNet.Api.Network.Get();
                HetznerDotNet.Api.Network network = await HetznerDotNet.Api.Network.Get(2282516);
                listNetwork[0].name = $"TEST - EDIT - {Guid.NewGuid()}";
                HetznerDotNet.Api.Network networkUpdate = await HetznerDotNet.Api.Network.Update(listNetwork[0]);
                await HetznerDotNet.Api.Network.Delete(listNetwork[0]);

                // Network - Subnet's
                await HetznerDotNet.Api.Network.SubnetCreate(network, "192.168.0.0/16", "eu-central");
                await HetznerDotNet.Api.Network.SubnetDelete(network, "192.168.0.0/16");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}