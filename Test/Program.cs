using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using HetznerDotNet;

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
                ApiCore.ApiToken = await File.ReadAllTextAsync("D:\\ApiKey.txt");

                //// Location
                //var locationList = await HetznerDotNet.Api.Location.Get();
                //string loc = String.Join(",", locationList.Select(x => x.Name));
                //var location = await HetznerDotNet.Api.Location.Get(locationList[0].Id);

                //// SshKey
                //HetznerDotNet.Api.SshKey sshKeyAdd = await HetznerDotNet.Api.SshKey.Create($"TEST - {Guid.NewGuid()}", valor);
                //sshKeyAdd.Name = $"Test - {Guid.NewGuid()}";
                //HetznerDotNet.Api.SshKey sshkeUpdate = await HetznerDotNet.Api.SshKey.Update(sshKeyAdd);
                //HetznerDotNet.Api.SshKey sshKeyGetOne = await HetznerDotNet.Api.SshKey.Get(sshKeyAdd.Id);
                //List<HetznerDotNet.Api.SshKey> sshKeyGetAll = await HetznerDotNet.Api.SshKey.Get();
                //await HetznerDotNet.Api.SshKey.Delete(sshKeyAdd);

                //// Images
                //List<HetznerDotNet.Api.Image> listImage = await HetznerDotNet.Api.Image.Get();
                //HetznerDotNet.Api.Image image = await HetznerDotNet.Api.Image.Get(listImage[15].Id);

                //// ServerType
                //List<HetznerDotNet.Api.ServerType> listServerType = await HetznerDotNet.Api.ServerType.Get();
                //HetznerDotNet.Api.ServerType serverType = await HetznerDotNet.Api.ServerType.Get(listServerType[0].Id);

                //// Network
                //HetznerDotNet.Api.Network networkAdd = await HetznerDotNet.Api.Network.Create($"Prueba", "192.168.0.0/16");
                //List<HetznerDotNet.Api.Network> listNetwork = await HetznerDotNet.Api.Network.Get();
                //HetznerDotNet.Api.Network network = await HetznerDotNet.Api.Network.Get(networkAdd.Id);
                //listNetwork[0].Name = $"TEST - EDIT - {Guid.NewGuid()}";
                //HetznerDotNet.Api.Network networkUpdate = await HetznerDotNet.Api.Network.Update(listNetwork[0]);
                //await HetznerDotNet.Api.Network.SubnetCreate(network, "192.168.0.0/16", "eu-central");
                //await HetznerDotNet.Api.Network.SubnetDelete(network, "192.168.0.0/16");
                //await HetznerDotNet.Api.Network.Delete(networkAdd);

                // PlacementGroup
                //HetznerDotNet.Api.PlacementGroup placementGroupAdd = await HetznerDotNet.Api.PlacementGroup.Create($"Test");
                //List<HetznerDotNet.Api.PlacementGroup> listPlacementGroup = await HetznerDotNet.Api.PlacementGroup.Get();
                //HetznerDotNet.Api.PlacementGroup placementGroup = await HetznerDotNet.Api.PlacementGroup.Get(listPlacementGroup[0].Id);
                //placementGroupAdd.Name = $"TEST - {Guid.NewGuid()}";
                //HetznerDotNet.Api.PlacementGroup placementGroupUpdate = await HetznerDotNet.Api.PlacementGroup.Update(placementGroupAdd);
                //await HetznerDotNet.Api.PlacementGroup.Delete(placementGroupAdd);

                // Volumes
                //HetznerDotNet.Api.Volume volumeCreate = await HetznerDotNet.Api.Volume.Create($"nvmexd-{Guid.NewGuid()}", 15, "xfs", "nbg1");
                //List<HetznerDotNet.Api.Volume> listvVolumes = await HetznerDotNet.Api.Volume.Get();
                //HetznerDotNet.Api.Volume volume = await HetznerDotNet.Api.Volume.Get(listvVolumes[0].Id);
                //volumeCreate.Name = $"TEST-{Guid.NewGuid()}";
                //HetznerDotNet.Api.Volume volumeEdit = await HetznerDotNet.Api.Volume.Update(volumeCreate);
                //await HetznerDotNet.Api.Volume.Delete(volumeCreate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Terminado.....");
            Console.ReadLine();
        }
    }
}