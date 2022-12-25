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

                // Set token
                HetznerDotNet.ApiCore.ApiToken = await File.ReadAllTextAsync("D:\\ApiKey.txt");

                //List<HetznerDotNet.Api.Datacenter> listDatacenters = await HetznerDotNet.Api.Datacenter.Get();
                //HetznerDotNet.Api.Datacenter datacenter = await HetznerDotNet.Api.Datacenter.Get(4);

                //// Location
                //List<HetznerDotNet.Api.Location> locationList = await HetznerDotNet.Api.Location.Get();
                //HetznerDotNet.Api.Location location = await HetznerDotNet.Api.Location.Get(1);
                //string loc = String.Join(",", locationList.Select(x => x.Name));

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
                //string des = "my placement group";
                //List<HetznerDotNet.Api.PlacementGroup> listPlacementGroup = await HetznerDotNet.Api.PlacementGroup.Get();
                //HetznerDotNet.Api.PlacementGroup placementGroup = await HetznerDotNet.Api.PlacementGroup.Get(listPlacementGroup[0].Id);
                //placementGroupAdd.Name = $"TEST - {Guid.NewGuid()}";
                //HetznerDotNet.Api.PlacementGroup placementGroupUpdate = await HetznerDotNet.Api.PlacementGroup.Update(placementGroupAdd);

                //await HetznerDotNet.Api.PlacementGroup.Delete(placementGroupAdd);

                //await HetznerDotNet.Api.PlacementGroup.Action.AddToPlacementGroup(107641, 26800991);
                //await HetznerDotNet.Api.PlacementGroup.Action.RemoveFromPlacementGroup(107641, 26800991);

                //// To update, we first get a PlacementGroup
                //HetznerDotNet.Api.PlacementGroup placementGroup = await HetznerDotNet.Api.PlacementGroup.Get(123);

                //// We change the description
                //placementGroup.Name = "new name";

                // Get the Placement Group
                //HetznerDotNet.Api.PlacementGroup placementGroup = await HetznerDotNet.Api.PlacementGroup.Get(123);

                //// Get the server
                //HetznerDotNet.Api.Server server = await HetznerDotNet.Api.Server.Get(123);

                //// Remove from Placement Group
                //await HetznerDotNet.Api.PlacementGroup.Action.RemoveFromPlacementGroup(placementGroup, server);

                // Volumes
                //HetznerDotNet.Api.Volume volumeCreate = await HetznerDotNet.Api.Volume.Create($"nvmexd-{Guid.NewGuid()}", 15, "xfs", "nbg1");
                //List<HetznerDotNet.Api.Volume> listvVolumes = await HetznerDotNet.Api.Volume.Get();
                //HetznerDotNet.Api.Volume volume = await HetznerDotNet.Api.Volume.Get(listvVolumes[0].Id);
                //volumeCreate.Name = $"TEST-{Guid.NewGuid()}";
                //HetznerDotNet.Api.Volume volumeEdit = await HetznerDotNet.Api.Volume.Update(volumeCreate);
                //await HetznerDotNet.Api.Volume.Delete(volumeCreate);

                // Set name
                //string name = "Load Balancer x1";

                //// Set location | For more information visit the Location section
                //int locationId = 4; // 4 == Ashburn, VA

                //// Size == 1 => Max Targets (Server) 25
                //// Size == 2 => Max Targets (Server) 75
                //// Size == 3 => Max Targets (Server) 150
                //int size = 1;

                //// Algorithm
                //// eLoadBalancerAlgorithm.round_robin or eLoadBalancerAlgorithm.least_connections | For more information https://docs.hetzner.cloud/#load-balancers-create-a-load-balancer
                //eLoadBalancerAlgorithm algorithm = eLoadBalancerAlgorithm.round_robin;

                //// Load Balancer
                //HetznerDotNet.Api.LoadBalancer loadBalancerAdd = await HetznerDotNet.Api.LoadBalancer.Create(name, locationId, size, algorithm);
                //List<HetznerDotNet.Api.LoadBalancer> listLoadBalancer = await HetznerDotNet.Api.LoadBalancer.Get();
                HetznerDotNet.Api.LoadBalancer loadBalancer = await HetznerDotNet.Api.LoadBalancer.Get(999064);
                //loadBalancer.Name = "New Name";

                //// Update
                //loadBalancer = await HetznerDotNet.Api.LoadBalancer.Update(loadBalancer);

                //await HetznerDotNet.Api.LoadBalancer.Delete(new HetznerDotNet.Api.LoadBalancer());

                //await HetznerDotNet.Api.LoadBalancer.Network.AttachToNetwork(loadBalancer, 2336180);

                // xxxxxxxx
                //await HetznerDotNet.Api.LoadBalancer.Network.AttachToNetwork(loadBalancer, 2336180, "192.168.12.125");
                await HetznerDotNet.Api.LoadBalancer.Network.DetachFromNetwork(loadBalancer, 2336180);

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
                //HetznerDotNet.Api.Firewall firewall = await HetznerDotNet.Api.Firewall.Get(123456789);
                //firewall.Name = $"TETS - {Guid.NewGuid()}";
                //firewall = await HetznerDotNet.Api.Firewall.Update(firewall);

                // Get firewall
                //HetznerDotNet.Api.Firewall firewall = await HetznerDotNet.Api.Firewall.Get(647249);

                //// ServID to which the firewall is to be assigned
                //long serverId = 26839334;

                //// Apply to resources
                //await HetznerDotNet.Api.Firewall.Targe.Remove(firewall, serverId);

                //// Enable port 80 / tcp / in / All traffic ipv4 and ipv6
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //Protocol = "tcp",
                //    Port = "80",
                //    Description = "Port 80 for http",
                //    SourceIps = new List<string> { "0.0.0.0/0", "::/0" }
                //});

                //// Enable port 22 / tcp / in / All traffic ipv4 and ipv6
                //listRules.Add(new HetznerDotNet.Api.Firewall.Rule
                //{
                //    Direction = "in",
                //    Protocol = "tcp",
                //    Port = "22",
                //    Description = "Port 22 for https",
                //    SourceIps = new List<string> { "0.0.0.0/0", "::/0" }
                //});

                //// Send rules
                //await HetznerDotNet.Api.Firewall.Rule.SetRules(firewall, listRules);

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

                // Datacenter
                //List<HetznerDotNet.Api.Datacenter> listDataDatacenter = await HetznerDotNet.Api.Datacenter.Get();
                //HetznerDotNet.Api.Datacenter datacenter = await HetznerDotNet.Api.Datacenter.Get(listDataDatacenter[0].Id);
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