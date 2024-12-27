using AuctionProject.DAL;
using AuctionProject.Models.Entities;
using AuctionProject.Service;
using Microsoft.EntityFrameworkCore;

namespace AuctionProject.Services
{
    public class BrandService : GenericService<Brand>, IBrandService
    {
        private readonly AppDbContext _context;
        public BrandService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<string>> GetAllNamesAsync()
        {
            return await _context.Brands
                .Select(b => b.BrandName)
                .ToListAsync();
        }

    }
}
