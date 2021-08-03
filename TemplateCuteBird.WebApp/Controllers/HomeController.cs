using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ApiIntegration;
using TemplateCuteBird.Utilities.Constants;
using TemplateCuteBird.WebApp.Models;

namespace TemplateCuteBird.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public HomeController(ILogger<HomeController> logger,
            ISlideApiClient slideApiClient, IProductApiClient productApiClient,
            ICategoryApiClient categoryApiClient)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                Categories = await _categoryApiClient.GetAll(),
                HomeProducts = await _productApiClient.GetHomeProducts(SystemConstants.ProductSettings.NumberHomeProducts)
            };


            foreach (var item in viewModel.HomeProducts)
            {
                var category = await _categoryApiClient.GetById(item.Id);
                item.Category = category;
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Privacy()
        {
            var viewModel = new HomeViewModel
            {
                Slides = await _slideApiClient.GetAll(),
                HomeProducts = await _productApiClient.GetHomeProducts(SystemConstants.ProductSettings.NumberHomeProducts)
            };
            return View(viewModel);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
