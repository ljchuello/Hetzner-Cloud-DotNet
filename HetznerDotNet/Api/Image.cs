using System.Collections.Generic;
using System.Threading.Tasks;
using HetznerDotNet.Objects.Image.GetOne;
using Newtonsoft.Json;

namespace HetznerDotNet.Api
{
    public class Image : HetznerDotNet.Objects.Image.Image
    {
        public static async Task<List<Image>> Get()
        {
            List<Image> listImage = new List<Image>();
            int page = 0;
            while (true)
            {
                // Nex
                page++;

                // Get list
                HetznerDotNet.Objects.Image.Get.Response response = JsonConvert.DeserializeObject<HetznerDotNet.Objects.Image.Get.Response>(await ApiCore.SendGetRequest($"/images?page={page}&per_page=25")) ?? new HetznerDotNet.Objects.Image.Get.Response();

                // Run
                foreach (Image row in response.images)
                {
                    listImage.Add(row);
                }

                // Finish?
                if (response.meta.pagination.next_page == null)
                {
                    // Yes, finish
                    return listImage;
                }
            }
        }

        public static async Task<Image> Get(long id)
        {
            // Get list
            Response response = JsonConvert.DeserializeObject<Response>(await ApiCore.SendGetRequest($"/images/{id}")) ?? new Response();

            // Return
            return response.image;
        }
    }
}
