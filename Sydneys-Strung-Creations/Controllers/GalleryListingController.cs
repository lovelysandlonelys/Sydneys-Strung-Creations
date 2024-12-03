using Microsoft.AspNetCore.Mvc;
using Sydneys_Strung_Creations.Data;
using Sydneys_Strung_Creations.Data.Services;

namespace Sydneys_Strung_Creations.Controllers
{
    public class GalleryListingController : Controller
    {
        private readonly IGalleryListingService _service;

        public GalleryListingController(IGalleryListingService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
