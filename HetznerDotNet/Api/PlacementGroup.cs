﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HetznerDotNet.Api
{
    public class PlacementGroup : Objects.PlacementGroup.PlacementGroup
    {
        public static async Task<List<PlacementGroup>> Get()
        {
            List<PlacementGroup> list = new List<PlacementGroup>();
            long page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                Objects.PlacementGroup.Get.Response response = JsonConvert.DeserializeObject<Objects.PlacementGroup.Get.Response>(await ApiCore.SendGetRequest($"/placement_groups?page={page}&per_page=25")) ?? new Objects.PlacementGroup.Get.Response();

                // Run
                foreach (PlacementGroup row in response.PlacementGroups)
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

        public static async Task<PlacementGroup> Get(long id)
        {
            // Get list
            Objects.PlacementGroup.GetOne.Response response = JsonConvert.DeserializeObject<Objects.PlacementGroup.GetOne.Response>(await ApiCore.SendGetRequest($"/placement_groups/{id}")) ?? new Objects.PlacementGroup.GetOne.Response();

            // Return
            return response.PlacementGroup;
        }

        public static async Task<PlacementGroup> Create(string name)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{name}\",\"type\":\"spread\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPostRequest("/placement_groups", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<PlacementGroup>($"{result["placement_group"]}") ?? new PlacementGroup();
        }

        public static async Task<PlacementGroup> Update(PlacementGroup placementGroup)
        {
            // Preparing raw
            string raw = $"{{\"name\":\"{placementGroup.Name}\"}}";

            // Send post
            string jsonResponse = await ApiCore.SendPutRequest($"/placement_groups/{placementGroup.Id}", raw);

            // Return
            JObject result = JObject.Parse(jsonResponse);
            return JsonConvert.DeserializeObject<PlacementGroup>($"{result["placement_group"]}") ?? new PlacementGroup();
        }

        public static async Task Delete(PlacementGroup placementGroup)
        {
            // Send post
            await ApiCore.SendDeleteRequest($"/placement_groups/{placementGroup.Id}");
        }

        public class Action
        {
            public static async Task AddToPlacementGroup(long placementGroupId, long serverId)
            {
                // Set raw
                string json = $"{{\"placement_group\":{placementGroupId}}}";

                // Send post
                await ApiCore.SendPostRequest($"/servers/{serverId}/actions/add_to_placement_group", json);
            }

            public static async Task AddToPlacementGroup(PlacementGroup placementGroup, Server server)
            {
                await AddToPlacementGroup(placementGroup.Id, server.Id);
            }

            public static async Task RemoveFromPlacementGroup(long placementGroupId, long serverId)
            {
                // Set raw
                string json = $"{{\"placement_group\":{placementGroupId}}}";

                // Send post
                await ApiCore.SendPostRequest($"/servers/{serverId}/actions/remove_from_placement_group", json);
            }

            public static async Task RemoveFromPlacementGroup(PlacementGroup placementGroup, Server server)
            {
                await RemoveFromPlacementGroup(placementGroup.Id, server.Id);
            }
        }
    }
}
