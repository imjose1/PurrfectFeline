using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PurrfectFeline.Models;




namespace PurrfectFeline.Controllers
{
    public class CatController : Controller
    {
        public async Task<IActionResult> Breeds()
        {

            List<SelectListItem> LstBreed = new List<SelectListItem>();
            CatBreedModel catBreed = new CatBreedModel();

            ListCatsBreedsModel catList = new ListCatsBreedsModel();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", "live_F9pFgfTNQsm0mJfBg0FpALoycqilewVeMw8LPpcsmqTZpsydTTRjvhINAQxvTyRE");

            var response = await client.GetAsync("https://api.thecatapi.com/v1/breeds");

            if (response.IsSuccessStatusCode)
            {
                var breedsJson = await response.Content.ReadAsStringAsync();
                var breeds = JsonConvert.DeserializeObject<List<CatBreedModel>>(breedsJson);

                if (breeds != null)
                {
                    foreach (var breed in breeds)
                    {
                        LstBreed.Add(new SelectListItem
                        {
                            Value = breed.Id,
                            Text = breed.Name,

                        });

                    }
                    if (LstBreed != null)
                    {
                        catBreed.LstBreed = LstBreed;
                        catList.LstBreeds = catBreed.LstBreed;
                    }

                }

                return View(catList);

            }

            return View("Error");
        }


        [HttpPost]
        public async Task<IActionResult> GetCatByBreed()
        {

            List<BreedTypeModel> LstOneCatBreed = new List<BreedTypeModel>();
            BreedTypeModel oneBreed = new BreedTypeModel();


            ListCatsBreedsModel selectedBreed = new ListCatsBreedsModel();



            var client = new HttpClient();
            string valorSeleccionado = Request.Form["breedId"];
            var response = await client.GetAsync("https://api.thecatapi.com/v1/images/search?limit=5&breed_ids=" + valorSeleccionado + "&api_key=live_F9pFgfTNQsm0mJfBg0FpALoycqilewVeMw8LPpcsmqTZpsydTTRjvhINAQxvTyRE");
            if (response.IsSuccessStatusCode)
            {
                var jsonGetOneBreed = await response.Content.ReadAsStringAsync();
                var getOneBreed = JsonConvert.DeserializeObject<List<BreedTypeModel>>(jsonGetOneBreed);


                if (getOneBreed != null)
                {

                    foreach (var catBreed in getOneBreed)
                    {
                        selectedBreed = new ListCatsBreedsModel();
                        selectedBreed.Id = catBreed.Id;
                        selectedBreed.Url = catBreed.Url;
                        selectedBreed.Width = catBreed.Width;
                        selectedBreed.Height = catBreed.Height;
                        selectedBreed.Breeds = catBreed.Breeds;


                        oneBreed = new BreedTypeModel();
                        oneBreed.Id = catBreed.Id;
                        oneBreed.Url = catBreed.Url;
                        oneBreed.Width = catBreed.Width;
                        oneBreed.Height = catBreed.Height;
                        oneBreed.Breeds = catBreed.Breeds;
                        LstOneCatBreed.Add(oneBreed);

                    }

                    if (getOneBreed != null)
                    {
                        oneBreed.LstOneCatBreed = LstOneCatBreed;

                        selectedBreed.SelectedBreed = LstOneCatBreed;

                    }
                    return View("Breeds", selectedBreed);
                }
            }
            return View("Error");
        }


    }
}
