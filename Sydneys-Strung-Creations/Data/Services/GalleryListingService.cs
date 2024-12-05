using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Data.Services
{
    public class GalleryListingService : IGalleryListingService
    {
        private readonly AppDbContext _context;

        public GalleryListingService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(gallary_listing listing)
        {
            _context.gallary_listing.Add(listing);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<gallary_listing>> GetAll()
        {
            var result = await _context.gallary_listing.ToListAsync();
            return result;
        }

        public gallary_listing GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public gallary_listing Update(int id, gallary_listing listing)
        {
            throw new NotImplementedException();
        }
    }
}
