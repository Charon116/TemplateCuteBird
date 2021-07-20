using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.Data.Enums;

namespace TemplateCuteBird.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; } //category thuong la null nen se co ?
        public string Name { get; set; }
        public Status Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }

    }
}
