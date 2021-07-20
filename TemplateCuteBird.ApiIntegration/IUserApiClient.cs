using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Common;
using TemplateCuteBird.ViewModels.Systems.Users;

namespace TemplateCuteBird.ApiIntegration
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest registerRequest);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUserPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> Update(Guid id,UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}
