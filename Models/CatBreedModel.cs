using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PurrfectFeline.Models
  
{
    public class CatBreedModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
       public List<SelectListItem> LstBreed { get; set; }

        //public CatBreedModel(List<CatBreedModel> possibleBreed)
        //{
        //    List<SelectListItem> LstBreed = new List<SelectListItem>();

        //    foreach (var breed in possibleBreed)
        //    {
        //        LstBreed.Add(new SelectListItem
        //        {

        //            Value = breed.Id,
        //            Text = breed.Name,
        //        });
        //    }


        //}
    }

}
