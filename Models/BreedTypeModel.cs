﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PurrfectFeline.Models;
using System.Text.Json.Serialization;

namespace PurrfectFeline.Models

{
    public class BreedTypeModel
        
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
      
        public List<CatInfoModel> Breeds { get; set; }

        
        public List<BreedTypeModel> LstOneCatBreed { get; set; }

    }

}
