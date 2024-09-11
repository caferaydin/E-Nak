using E_Nak.Application.Abstract.Service.Account;
using E_Nak.Application.Exceptions.Account;
using E_Nak.Application.Helpers;
using E_Nak.Application.Model;
using E_Nak.Application.Model.Requests.User;
using E_Nak.Application.Model.Response.User;
using E_Nak.Application.Model.View.User;
using E_Nak.Domain.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Nak.Persistence.Services.Account
{

    public class UserService : IUserService
    {
        #region Fields & Ctor
        readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        #endregion

        #region Methods

        public async Task<CreateUserResponse> CreateAsync(CreateUserRequest model)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Username,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
            };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            CreateUserResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
            {
                // Varsayılan olarak "User" rolünü ata
                IdentityResult roleResult = await _userManager.AddToRoleAsync(user, "User");

                if (roleResult.Succeeded)
                {
                    response.Message = "Kullanıcı başarıyla oluşturulmuştur ve 'User' rolü atanmıştır.";
                }
                else
                {
                    response.Message = "Kullanıcı oluşturuldu, ancak rol atama sırasında bir hata oluştu: ";
                    foreach (var error in roleResult.Errors)
                    {
                        response.Message += $"{error.Code} - {error.Description}\n";
                    }
                }
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description}\n";
                }
            }

            return response;
        }
        public async Task UpdateRefreshTokenAsync(string refreshToken, User user, DateTime accessTokenDate, int addOnAccessTokenDate)
        {
            if (user != null)
            {
                user.RefreshToken = refreshToken;
                user.RefreshTokenEndDate = accessTokenDate.AddSeconds(addOnAccessTokenDate);
                await _userManager.UpdateAsync(user);
            }
            else
                throw new NotFoundUserException();
        }
        public async Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                resetToken = resetToken.UrlDecode();
                IdentityResult result = await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
                if (result.Succeeded)
                    await _userManager.UpdateSecurityStampAsync(user);
                else
                    throw new PasswordChangeFailedException();
            }
        }
        public async Task<PaginatedList<UserViewModel>> GetAllUsersAsync(int pageIndex, int pageSize)
        {
            var users = _userManager.Users.Where(x => x.EmailConfirmed == true).AsQueryable();

            var userModels = users.Select(user => new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                TwoFactorEnabled = user.TwoFactorEnabled,
                UserName = user.UserName
            }).AsQueryable();

            return await PaginatedList<UserViewModel>.CreateAsync(userModels, pageIndex, pageSize);


        }
        public int TotalUsersCount => _userManager.Users.Count();
        public async Task AssignRoleToUserAsnyc(string userId, string[] roles)
        {
            User? user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, userRoles);

                await _userManager.AddToRolesAsync(user, roles);
            }
        }
        public async Task<string[]> GetRolesToUserAsync(string userIdOrName)
        {
            User user = await _userManager.FindByIdAsync(userIdOrName);
            if (user == null)
                user = await _userManager.FindByNameAsync(userIdOrName);

            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                return userRoles.ToArray();
            }
            return new string[] { };
        }
        public async Task<bool> IsUsernameUniqueAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            return user == null;
        }
        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user == null;
        }
        public async Task<bool> IsPhoneNumberUniqueAsync(string phoneNumber)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            return user == null;
        }

        #endregion
    }

}
