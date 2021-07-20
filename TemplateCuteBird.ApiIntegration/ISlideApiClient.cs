using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Categories;
using TemplateCuteBird.ViewModels.Common;
using TemplateCuteBird.ViewModels.Systems.Utilities.Slides;

namespace TemplateCuteBird.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
