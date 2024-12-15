using Microsoft.AspNetCore.Identity;

namespace AuctionProject.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }

        // Navigation Properties
        public ICollection<Car> Cars { get; set; } // One-to-Many with Cars
        public ICollection<Bid> Bids { get; set; } // One-to-Many with Bids
        public ICollection<Order> Orders { get; set; } // One-to-Many with Orders
    }
}
