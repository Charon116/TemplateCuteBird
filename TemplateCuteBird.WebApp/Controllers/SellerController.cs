using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ApiIntegration;
using TemplateCuteBird.ViewModels.Catalog.Products;

namespace TemplateCuteBird.WebApp.Controllers
{
    public class SellerController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly ICategoryApiClient _categoryApiClient;
        public SellerController(IProductApiClient productApiClient, IConfiguration configuration,
     ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
            _categoryApiClient = categoryApiClient;
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ManageOrder()
        {
            return View();
        }

    
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productApiClient.CreateProduct(request);
            if (result)
            {
                TempData["result"] = "Add success";
                return RedirectToAction("Dashboard");
            }

            ModelState.AddModelError("", "Add product failure");
            return View(request);
        }
    }

}
