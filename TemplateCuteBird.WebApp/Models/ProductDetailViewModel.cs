using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Categories;
using TemplateCuteBird.ViewModels.Catalog.ProductImages;
using TemplateCuteBird.ViewModels.Catalog.Products;

namespace TemplateCuteBird.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
