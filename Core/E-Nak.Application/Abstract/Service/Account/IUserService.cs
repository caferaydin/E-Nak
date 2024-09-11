using E_Nak.Application.Model;
using E_Nak.Application.Model.Requests.User;
using E_Nak.Application.Model.Response.User;
using E_Nak.Application.Model.View.User;
using E_Nak.Domain.Entities.Account;

namespace E_Nak.Application.Abstract.Service.Account
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUserRequest model);
        Task UpdateRefreshTokenAsync(string refreshToken, User user, DateTime accessTokenDate, int addOnAccessTokenDate);
        Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
        Task<PaginatedList<UserViewModel>> GetAllUsersAsync(int pageIndex, int pageSize);
        int TotalUsersCount { get; }
        Task AssignRoleToUserAsnyc(string userId, string[] roles);
        Task<string[]> GetRolesToUserAsync(string userIdOrName);
        Task<bool> IsUsernameUniqueAsync(string username);
        Task<bool> IsEmailUniqueAsync(string email);
        Task<bool> IsPhoneNumberUniqueAsync(string phoneNumber);
    }
}
