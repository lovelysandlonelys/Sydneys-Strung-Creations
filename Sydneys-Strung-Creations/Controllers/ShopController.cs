using Microsoft.AspNetCore.Mvc;
using Sydneys_Strung_Creations.Data;
using Sydneys_Strung_Creations.Models;
using System.Linq;

namespace Sydneys_Strung_Creations.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Shop/Shop
        public IActionResult Shop()
        {
            // Retrieve product names for dropdown
            var products = _context.gallary_listing.Select(p => new { p.ProductName }).ToList();
            ViewBag.Products = products; // Pass products to the view
            return View(); // Views/Shop/Shop.cshtml
        }

        // POST: Shop/SubmitOrder
        [HttpPost]
        public IActionResult SubmitOrder(order_form order)
        {
            if (ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now; 
                _context.order_forms.Add(order); 
                _context.SaveChanges(); 

                return RedirectToAction("OrderConfirmation"); // Redirect to confirmation
            }

            // reload form in the case the model is invalid
            var products = _context.gallary_listing.Select(p => new { p.ProductName }).ToList();
            ViewBag.Products = products;
            return View("Shop", order);
        }

        // GET: Shop/OrderConfirmation
        public IActionResult OrderConfirmation()
        {
            return View(); // Views/Shop/OrderConfirmation.cshtml
        }
    }
}
