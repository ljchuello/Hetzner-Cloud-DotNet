using Newtonsoft.Json;

namespace HetznerCloudApi.Api
{
    public class Image : Objects.Image.Image
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
                Objects.Image.Get.Response response = JsonConvert.DeserializeObject<Objects.Image.Get.Response>(await ApiCore.SendGetRequest($"/images?page={page}&per_page=25")) ?? new Objects.Image.Get.Response();

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
            Objects.Image.GetOne.Response response = JsonConvert.DeserializeObject<Objects.Image.GetOne.Response>(await ApiCore.SendGetRequest($"/images/{id}")) ?? new Objects.Image.GetOne.Response();

            // Return
            return response.image;
        }
    }
}
