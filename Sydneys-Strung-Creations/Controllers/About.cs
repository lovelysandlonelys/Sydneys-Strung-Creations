using Microsoft.AspNetCore.Mvc;

namespace Sydneys_Strung_Creations.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public IActionResult Index()
        {
            return View();
        }
    }
}
