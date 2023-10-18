using E_Nak.Application.Abstract.Service.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Nak.Application.Abstract.Service
{
    public interface IAuthService : IExternalAuth, IInternalAuth
    {
        Task PasswordResetAsnyc(string email);
        Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
