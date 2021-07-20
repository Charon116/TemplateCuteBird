using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCuteBird.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string Detail { set; get; }
        public decimal Price { get; set; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumnailImage { get; set; }

    }
}
