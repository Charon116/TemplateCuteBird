using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.Products;
using TemplateCuteBird.ViewModels.Common;
using TemplateCuteBird.ViewModels.Systems.Users;

namespace TemplateCuteBird.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id,CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetHomeProducts(int take);
        //thêm nè 
        Task<List<ProductViewModel>> GetPictureProducts(int takepicture, string nameCategory);
    }
}
