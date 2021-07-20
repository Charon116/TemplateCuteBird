using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TemplateCuteBird.Data.Entities
{
    [Table("Products")]
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public string Name { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Title { set; get; }
        public string Detail { set; get; }
        public Guid UserId { get; set; }

        public bool? IsFeatured { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public AppUser AppUser { get; set; }

    }
}
