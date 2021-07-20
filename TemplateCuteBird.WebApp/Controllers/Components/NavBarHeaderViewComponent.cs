using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateCuteBird.ApiIntegration;

namespace TemplateCuteBird.WebApp.Controllers.Components
{
    public class NavBarHeaderViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public NavBarHeaderViewComponent(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _categoryApiClient.GetAll();
            return View(items);
        }
    }
}
