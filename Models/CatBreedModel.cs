using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PurrfectFeline.Models
  
{
    public class CatBreedModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
       public List<SelectListItem> LstBreed { get; set; }

      
    }

}
