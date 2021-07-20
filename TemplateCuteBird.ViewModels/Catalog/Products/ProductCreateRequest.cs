using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCuteBird.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Detail { get; set; }
        public string Title { get; set; }
        public int Stock { get; set; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }

    }
}
