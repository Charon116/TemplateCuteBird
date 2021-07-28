using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
     
        public IFormFile ThumbnailImage { get; set; }

    }
}
