using Microsoft.AspNetCore.Mvc.Rendering;

namespace PurrfectFeline.Models
{
    public class BreedTypeModel
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<BreedTypeModel> LstOneCatBreed { get; set; }
    }
    
}
