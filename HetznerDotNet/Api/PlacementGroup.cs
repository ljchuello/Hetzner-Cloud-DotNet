using Newtonsoft.Json;
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
    }
}
