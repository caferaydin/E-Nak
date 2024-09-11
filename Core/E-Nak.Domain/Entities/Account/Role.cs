using Microsoft.AspNetCore.Identity;

namespace E_Nak.Domain.Entities.Account
{
    public class Role : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
