using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Common;
using TemplateCuteBird.ViewModels.Systems.Users;

namespace TemplateCuteBird.Application.Systems.User
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id ,UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id,RoleAssignRequest request);
    }
}
