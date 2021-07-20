using System;
using System.Collections.Generic;
using System.Text;
using TemplateCuteBird.Data.Enums;

namespace TemplateCuteBird.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public OrderStatus Status { set; get; }
        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser AppUser { get; set; }

    }
}
