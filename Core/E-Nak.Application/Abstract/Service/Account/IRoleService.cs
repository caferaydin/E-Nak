using E_Nak.Application.Model.Response.User;

namespace E_Nak.Application.Abstract.Service.Account
{
    public interface IRoleService
    {
        (IEnumerable<RoleResponse>, int) GetAllRoles(int page, int size);
        Task<(string id, string name)> GetRoleById(string id);
        Task<bool> CreateRole(string name, string description);
        Task<bool> DeleteRole(string id);
        Task<bool> UpdateRole(string id, string name);
    }
}
