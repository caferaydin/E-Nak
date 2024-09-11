using E_Nak.Application.Abstract.Service.Account;
using E_Nak.Application.Model.Response.User;
using E_Nak.Domain.Entities.Account;
using Microsoft.AspNetCore.Identity;

namespace E_Nak.Persistence.Services.Account
{
    public class RoleService : IRoleService
    {
        #region Fields & Ctor
        readonly RoleManager<Role> _roleManager;

        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        #endregion

        #region Methods
        public async Task<bool> CreateRole(string name, string description)
        {
            IdentityResult result = await _roleManager.CreateAsync(new() { Id = Guid.NewGuid().ToString(), Name = name, Description = description });

            return result.Succeeded;
        }
        public async Task<bool> DeleteRole(string id)
        {
            Role appRole = await _roleManager.FindByIdAsync(id);
            IdentityResult result = await _roleManager.DeleteAsync(appRole);
            return result.Succeeded;
        }
        public (IEnumerable<RoleResponse>, int) GetAllRoles(int page, int size)
        {
            var query = _roleManager.Roles;

            IQueryable<Role> rolesQuery = null;

            if (page != -1 && size != -1)
                rolesQuery = query.Skip(page * size).Take(size);
            else
                rolesQuery = query;

            var roles = rolesQuery
                .Select(r => new RoleResponse { Id = r.Id, Name = r.Name, Description = r.Description })
                .ToList();

            // Toplam sayıyı al
            var totalCount = query.Count();

            return (roles, totalCount);
        }
        public async Task<(string id, string name)> GetRoleById(string id)
        {
            //var role = await _roleManager.GetRoleIdAsync(new() { Id = id});
            var item = await _roleManager.FindByIdAsync(id);

            return (item.Id, item.Name);
        }
        public async Task<bool> UpdateRole(string id, string name)
        {
            Role role = await _roleManager.FindByIdAsync(id);
            role.Name = name;
            IdentityResult result = await _roleManager.UpdateAsync(role);
            return result.Succeeded;
        }

        #endregion
    }
}
