using Microsoft.AspNetCore.Identity;

namespace E_Nak.Domain.Entities.Identity
{
    public class AppUser  : IdentityUser<string>// Edit Field
    {
        public string NameSurname { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }

    }
}
