using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.Data.EF;
using TemplateCuteBird.ViewModels.Catalog.Categories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TemplateCuteBird.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly TemplateShopDbContext _context;
    

        public CategoryService(TemplateShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories
                        select new {c};
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                ParentId = x.c.ParentId
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var query = from c in _context.Categories
                        select new { c};
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                ParentId = x.c.ParentId
            }).FirstOrDefaultAsync();
        }
    }
}
