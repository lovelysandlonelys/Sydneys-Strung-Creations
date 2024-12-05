using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Data.Services
{
    public interface IGalleryListingService
    {
        Task <IEnumerable<gallary_listing>> GetAll();

        gallary_listing GetByID(int id);

        void Add(gallary_listing listing);

        gallary_listing Update(int id, gallary_listing listing);

        void Delete(int id);
    }
}
