using Microsoft.AspNetCore.Identity;

namespace GscStore.Models
{
    public class AdminUser : IdentityUser
    {
        public string Address { get; set; } = "admin";

    }
}