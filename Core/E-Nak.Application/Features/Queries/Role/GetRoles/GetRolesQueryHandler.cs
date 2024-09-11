using E_Nak.Application.Abstract.Service.Account;
using E_Nak.Application.Model.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Application.Features.Queries.Role.GetRoles
{
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQueryRequest, GetRolesQueryResponse>
    {
        readonly IRoleService _roleService;
        
        public GetRolesQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetRolesQueryResponse> Handle(GetRolesQueryRequest request, CancellationToken cancellationToken)
        {
            var (datas, count) = _roleService.GetAllRoles(request.Page, request.Size);
            var totalPages = (int)Math.Ceiling((double)count / request.Size);

            return new GetRolesQueryResponse
            {
                Roles = datas.Select(r => new RoleResponse { Id = r.Id, Name = r.Name, Description = r.Description }),
                CurrentPage = request.Page,
                PageSize = request.Size,
                TotalCount = count,
                TotalPages = totalPages,
                Status = 200, 
                AvailablePageSizes = new List<int> { 10, 20, 50, 100 } 
            };
        }
    }
}
