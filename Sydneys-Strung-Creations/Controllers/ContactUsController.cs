using Microsoft.AspNetCore.Mvc;
using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: Contact
        public IActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Typically, you would save the contact data or send an email here
                // For this example, we will simulate a successful form submission

                TempData["SuccessMessage"] = "Thank you for contacting us! We will get back to you soon.";

                // Redirecting to avoid re-posting the form on refresh
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
