using Microsoft.AspNetCore.Identity;

namespace AuctionProject.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty; // User's full name
        public DateTime DateOfBirth { get; set; } // User's date of birth
        public string Address { get; set; } = string.Empty; // User's address
        public string ProfilePictureUrl { get; set; } = string.Empty; // Profile picture URL
        public List<Bid> Bids { get; set; }
        public List<Order> Orders { get; set; }

    }
}
