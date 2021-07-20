using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Categories;

namespace TemplateCuteBird.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);
    }
}
