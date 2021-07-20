using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Products;
using TemplateCuteBird.ViewModels.Systems.Utilities.Slides;

namespace TemplateCuteBird.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; } 

        public List<ProductViewModel> HomeProducts { get; set; }
    }
}
