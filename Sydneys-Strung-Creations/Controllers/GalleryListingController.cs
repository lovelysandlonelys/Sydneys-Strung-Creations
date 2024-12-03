using Microsoft.AspNetCore.Mvc;
using Sydneys_Strung_Creations.Data;

namespace Sydneys_Strung_Creations.Controllers
{
    public class GalleryListingController : Controller
    {
        private readonly AppDbContext _context;

        public GalleryListingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.gallary_listing.ToList();
            return View(data);
        }
    }
}
