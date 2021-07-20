using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Common;
using TemplateCuteBird.ViewModels.Systems.Roles;

namespace TemplateCuteBird.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}
