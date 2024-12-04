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

        public IActionResult Shop()
        {
            // Gets product names for dropdown
            var products = _context.gallary_listing.Select(p => new { p.ProductName }).ToList();
            ViewBag.Products = products; 
            return View(); 
        }

        [HttpPost]
        public IActionResult SubmitOrder(order_form order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Console.WriteLine("Model is valid.");
                    order.OrderDate = DateTime.Now;

                    // this adds the order to the database
                    _context.order_forms.Add(order);
                    _context.SaveChanges(); // Save to the database
                    Console.WriteLine("Order saved to database.");

                    // Store the order in TempData
                    TempData["OrderId"] = order.Id;

                    // Redirect to the OrderConfirmation page
                    return RedirectToAction("OrderConfirmation");
                }
                else
                {
                    Console.WriteLine("Model is invalid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // reload if the form is invalid
            var products = _context.gallary_listing.Select(p => new { p.ProductName }).ToList();
            ViewBag.Products = products;
            Console.WriteLine("Reloading form due to error.");
            return View("Shop", order);
        }


        public IActionResult OrderConfirmation()
        {
            // gets the orderID from TempData
            var orderId = TempData["OrderId"];
            if (orderId == null)
            {
                return RedirectToAction("Shop");
            }

            // Pass the OrderId to the view
            ViewBag.OrderId = orderId;
            return View();
        }

    }
}
