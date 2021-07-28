using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Catalog.ProductImages;
using TemplateCuteBird.ViewModels.Catalog.Products;

using TemplateCuteBird.ViewModels.Common;

namespace TemplateCuteBird.Application.Catalog.Products
{
    public interface IProductService
    {
     
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<ApiResult<int>> Delete(int Id);

        Task<ProductViewModel> GetById(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuanity);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResult<ProductViewModel>> GetAllByCategoryById(string Name,GetPublicProductPagingRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<List<ProductViewModel>> GetHomeProducts(int take);
    }
}
