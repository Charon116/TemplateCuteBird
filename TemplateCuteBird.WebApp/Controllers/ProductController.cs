using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ApiIntegration;
using TemplateCuteBird.ViewModels.Catalog.Products;
using TemplateCuteBird.WebApp.Models;

namespace TemplateCuteBird.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
           
        }
        public async Task<IActionResult> Detail(int id)
        {
            var product = await _productApiClient.GetById(id);
            return View(new ProductDetailViewModel()
            {
                Product = product,
                
            });
        }

        public async Task<IActionResult> Filter(int id, int page=1)
        {
            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            { 
                CategoryId = id,
                PageIndex = page,
                PageSize = 10
            });

            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(id),
                Products = products
            });
        }

        public async Task<IActionResult> Payment(int? id)
        {
            if (id != null)
            {
                var product = await _productApiClient.GetById(id.Value);
                return View(new ProductDetailViewModel()
                {
                    Product = product,

                });
            }
            else {
                return Redirect("/");
            }
        }
    }
}
