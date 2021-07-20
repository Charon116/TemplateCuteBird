using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.ViewModels.Systems.Roles;

namespace TemplateCuteBird.Application.Systems.Roles
{
    public interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
    }
}
