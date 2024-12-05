using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Sydneys_Strung_Creations.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<gallary_listing> gallary_listing { get; set; }
        public DbSet<jewlery_template> jewlery_template { get; set; }
        public DbSet<order_form> order_forms { get; set; }
    }
}
