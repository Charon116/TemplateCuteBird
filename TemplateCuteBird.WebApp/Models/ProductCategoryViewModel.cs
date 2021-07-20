using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Categories;
using TemplateCuteBird.ViewModels.Catalog.Products;
using TemplateCuteBird.ViewModels.Common;

namespace TemplateCuteBird.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
