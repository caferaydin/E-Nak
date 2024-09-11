using E_Nak.Application.Model.Response.User;

namespace E_Nak.Application.Features.Queries.Role.GetRoles
{
    public class GetRolesQueryResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public int Status { get; set; }
        public IEnumerable<int> AvailablePageSizes { get; set; }
    }
}
