using AuctionProject.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuctionProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }


        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensure Identity tables are configured

            // Auction → Order (One-to-One)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Auction)
                .WithOne(a => a.Order)
                .HasForeignKey<Order>(o => o.AuctionID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            // Auction → Bid (One-to-Many)
            modelBuilder.Entity<Bid>()
                .HasOne(b => b.Auction)
                .WithMany(a => a.Bids)
                .HasForeignKey(b => b.AuctionID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            // Auction → AppUser (Winner)
            modelBuilder.Entity<Auction>()
                .HasOne(a => a.Buyer)
                .WithMany()
                .HasForeignKey(a => a.WinnerID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            // Car → Auction (One-to-One)
            modelBuilder.Entity<Auction>()
                .HasOne(a => a.Car)
                .WithOne(c => c.Auction)
                .HasForeignKey<Auction>(a => a.CarID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            // Bid → AppUser (Many-to-One)
            modelBuilder.Entity<Bid>()
                .HasOne(b => b.Buyer)
                .WithMany(u => u.Bids)
                .HasForeignKey(b => b.BidderID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
        }



    }
}