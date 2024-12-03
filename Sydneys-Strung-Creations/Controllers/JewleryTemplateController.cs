using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Data;

namespace Sydneys_Strung_Creations.Controllers
{
    public class JewleryTemplateController : Controller
    {
        private readonly AppDbContext _context;

        public JewleryTemplateController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allJewleryTemplates = await _context.jewlery_template.ToListAsync();
            return View();
        }
    }
}
