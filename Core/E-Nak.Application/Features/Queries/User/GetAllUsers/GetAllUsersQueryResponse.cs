using E_Nak.Application.Model.View.User;

namespace E_Nak.Application.Features.Queries.User.GetAllUsers
{
    public class GetAllUsersQueryResponse
    {
        public List<UserViewModel> Users { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<int> AvailablePageSizes { get; set; } // Eklenen özellik
    }
}
