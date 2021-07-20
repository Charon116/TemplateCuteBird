using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateCuteBird.ViewModels.CheckOut
{
    public class CheckoutRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public List<OrderDetailViewModel> OrderDetails { set; get; } = new List<OrderDetailViewModel>();
    }
}
