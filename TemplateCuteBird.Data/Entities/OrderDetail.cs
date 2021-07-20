using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.Data.Enums;

namespace TemplateCuteBird.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public decimal Price { set; get; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Status Status { set; get; }
    }
}
