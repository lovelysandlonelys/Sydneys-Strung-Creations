using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sydneys_Strung_Creations.Data;
using Sydneys_Strung_Creations.Data.Services;
using Sydneys_Strung_Creations.Data.Static;
using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class GalleryListingController : Controller
    {
        private readonly IGalleryListingService _service;

        public GalleryListingController(IGalleryListingService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get Request: GalleryListing/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("JewleryPicturePath,ProductName,ProductDescription,JewleryCategory,FocalColor")]gallary_listing new_listing)
        {
            if (!ModelState.IsValid)
            {
                return View(new_listing);
            }

            // Ensure /images/ is prefixed to JewleryPicturePath
            if (!new_listing.JewleryPicturePath.StartsWith("/images/"))
            {
                new_listing.JewleryPicturePath = $"/images/{new_listing.JewleryPicturePath}";
            }

            _service.Add(new_listing);
            return RedirectToAction(nameof(Index));
        }


    }
}
