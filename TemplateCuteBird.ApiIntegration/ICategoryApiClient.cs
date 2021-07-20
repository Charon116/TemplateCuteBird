using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Categories;
using TemplateCuteBird.ViewModels.Common;

namespace TemplateCuteBird.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);
    }
}
