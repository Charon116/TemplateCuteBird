using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateCuteBird.WebApp.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ManageOrder()
        {
            return View();
        }

        public IActionResult CreateGig()
        {
            return View();
        }
    }
}
