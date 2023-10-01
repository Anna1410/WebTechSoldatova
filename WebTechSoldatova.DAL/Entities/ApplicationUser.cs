using Microsoft.AspNetCore.Identity;

namespace WebTechSoldatova.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? AvatarImage { get; set; }
    }
}
