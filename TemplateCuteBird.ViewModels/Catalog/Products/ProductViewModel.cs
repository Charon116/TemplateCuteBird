using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.ViewModels.Catalog.Categories;

namespace TemplateCuteBird.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Title { set; get; }
        public string Detail { set; get; }
        public Guid UserId { get; set; }
        public string ThumbnailImage { get; set; }
        public bool? IsFeatured { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public CategoryViewModel Category { get; set; }
    }
}
