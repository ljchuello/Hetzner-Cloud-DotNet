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
                List<HetznerDotNet.Api.Image> listImage = await HetznerDotNet.Api.Image.Get();
                HetznerDotNet.Api.Image image = await HetznerDotNet.Api.Image.Get(listImage[15].Id);

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

                // Load Balancer
                //HetznerDotNet.Api.LoadBalancer loadBalancerAdd = await HetznerDotNet.Api.LoadBalancer.Create("xD", 4, 1, eLoadBalancerAlgorithm.round_robin);
                //List<HetznerDotNet.Api.LoadBalancer> listLoadBalancer = await HetznerDotNet.Api.LoadBalancer.Get();
                //HetznerDotNet.Api.LoadBalancer loadBalancer = await HetznerDotNet.Api.LoadBalancer.Get(listLoadBalancer[0].Id);
                //loadBalancer.Name = "Putisimo";
                //loadBalancer = await HetznerDotNet.Api.LoadBalancer.Update(loadBalancer);
                //await HetznerDotNet.Api.LoadBalancer.Network.AttachToNetwork(listLoadBalancer[0], 2291088, "192.168.1.2");
                //await HetznerDotNet.Api.LoadBalancer.Network.AttachToNetwork(listLoadBalancer[0], 2291088);
                //await HetznerDotNet.Api.LoadBalancer.Network.DetachFromNetwork(listLoadBalancer[0], 2291088);
                //await HetznerDotNet.Api.LoadBalancer.Delete(loadBalancer);
                //await HetznerDotNet.Api.LoadBalancer.Service.Add(listLoadBalancer[0], "tcp", 27017, 3389);
                //await HetznerDotNet.Api.LoadBalancer.Service.Add(listLoadBalancer[0], "http", 80, 80);
                //await HetznerDotNet.Api.LoadBalancer.Service.Add(listLoadBalancer[0], "https", 443, 80, certificates:new List<long>{ 1120476 }, redirectHttpToHttps:false);
                //await HetznerDotNet.Api.LoadBalancer.Service.Remove(listLoadBalancer[0], 27017);
                //await HetznerDotNet.Api.LoadBalancer.Service.Remove(listLoadBalancer[0], 80);
                //await HetznerDotNet.Api.LoadBalancer.Service.Remove(listLoadBalancer[0], 443);
                //await HetznerDotNet.Api.LoadBalancer.Target.Add(listLoadBalancer[0], 26419059, usePrivateIp: false);
                //await HetznerDotNet.Api.LoadBalancer.Target.Add(listLoadBalancer[0], 26419059, usePrivateIp: true);
                //await HetznerDotNet.Api.LoadBalancer.Target.Add(listLoadBalancer[0], 26419059);
                //await HetznerDotNet.Api.LoadBalancer.Target.Remove(listLoadBalancer[0], 26419059);

                // Firewall
                //HetznerDotNet.Api.Firewall firewall = await HetznerDotNet.Api.Firewall.Create("LJChuello");
                //List<HetznerDotNet.Api.Firewall> listFirewalls = await HetznerDotNet.Api.Firewall.Get();
                //await HetznerDotNet.Api.Firewall.Targe.Add(listFirewalls[0], 26437692);
                //await HetznerDotNet.Api.Firewall.Targe.Remove(listFirewalls[0], 26437692);
                //firewall = await HetznerDotNet.Api.Firewall.Get(listFirewalls[0].Id);
                //firewall.Name = $"TETS - {Guid.NewGuid()}";
                //firewall = await HetznerDotNet.Api.Firewall.Update(firewall);

                //List<HetznerDotNet.Api.Firewall.Rule> listRules = new List<HetznerDotNet.Api.Firewall.Rule>();
                //// Enable port 80 / tcp / in / All traffic ipv4 and ipv6
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //    Protocol = "tcp",
                //    Port = "80",
                //    Description = "Port 80 for http",
                //    SourceIps = new List<string>{"0.0.0.0/0", "::/0"}
                //});
                //// Enable port 443 / tcp / in / All traffic ipv4 and ipv6
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //    Protocol = "tcp",
                //    Port = "443",
                //    Description = "Port 443 for https",
                //    SourceIps = new List<string> { "0.0.0.0/0", "::/0" }
                //});
                //// Enable port range 40000-50000 / tcp / in / only 8.8.8.8
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //    Protocol = "tcp",
                //    Port = "40000-50000",
                //    Description = "Example port range",
                //    SourceIps = new List<string> { "8.8.8.8/32" }
                //});
                //// Enable port any / tcp / in / only 8.8.8.8
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //    Protocol = "tcp",
                //    Port = "any",
                //    Description = "All port open for my ip",
                //    SourceIps = new List<string> { "8.8.8.8/32" }
                //});
                //// Enable port any / tcp / out / All traffic
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "out",
                //    Protocol = "tcp",
                //    Port = "any",
                //    Description = "All port out open",
                //    DestinationIps = new List<string> { "0.0.0.0/0", "::/0" }
                //});
                //// Send rules
                //await HetznerDotNet.Api.Firewall.Rule.SetRules(listFirewalls[0], listRules);

                //await HetznerDotNet.Api.Firewall.Delete(firewall);

                // Server
                //HetznerDotNet.Api.Server server = await HetznerDotNet.Api.Server.Create(
                //    $"Test-{Guid.NewGuid()}",
                //    new List<long> { 9304509 },
                //    4,
                //    67794396,
                //    22,
                //    enableIpv4:true,
                //    enableIpv6:true);
                //List<HetznerDotNet.Api.Server> listServer = await HetznerDotNet.Api.Server.Get();
                //HetznerDotNet.Api.Server server = await HetznerDotNet.Api.Server.Get(listServer[0].Id);
                //server.Name = "LaloLanda";
                //server = await HetznerDotNet.Api.Server.Update(server);
                //await HetznerDotNet.Api.Server.Delete(new HetznerDotNet.Api.Server
                //{
                //    Id = 123456789
                //});
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