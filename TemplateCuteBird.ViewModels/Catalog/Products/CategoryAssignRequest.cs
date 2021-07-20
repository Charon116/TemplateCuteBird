using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.ViewModels.Systems.Users;

namespace TemplateCuteBird.ViewModels.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}
