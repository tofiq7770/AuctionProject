using AuctionProject.Models.Entities;
using AuctionProject.Service.Interface;

namespace AuctionProject.Services
{
    public interface IBrandService : IGenericService<Brand>
    {
        Task<IEnumerable<string>> GetAllNamesAsync();

    }
}
