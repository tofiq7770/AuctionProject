using Microsoft.AspNetCore.Identity;

namespace AuctionProject.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
