using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateCuteBird.Data.Entities;
using TemplateCuteBird.ViewModels.Systems.Roles;

namespace TemplateCuteBird.Application.Systems.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> rolesManager)
        {
            _roleManager = rolesManager;
        }
        public async Task<List<RoleViewModel>> GetAll()
        {
            var roles = await _roleManager.Roles.
                Select(x => new RoleViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();
            return roles;
        }
    }
}
