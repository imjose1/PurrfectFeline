using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PurrfectFeline.Models;



namespace PurrfectFeline.Controllers
{
   public class CatController: Controller
    {
        public async Task<IActionResult> Breeds(int? breedId)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", "live_F9pFgfTNQsm0mJfBg0FpALoycqilewVeMw8LPpcsmqTZpsydTTRjvhINAQxvTyRE");

            var response = await client.GetAsync("https://api.thecatapi.com/v1/breeds");

            if (response.IsSuccessStatusCode)
            {
                var breedsJson = await response.Content.ReadAsStringAsync();
                var breeds = JsonConvert.DeserializeObject<List<CatBreedModel>>(breedsJson);

                ViewBag.BreedId = breedId;

                return View(breeds);
            }

            return View("Error");
        }

    }
}
