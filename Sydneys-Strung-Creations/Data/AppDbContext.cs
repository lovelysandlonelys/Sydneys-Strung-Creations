using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<gallary_listing> gallary_listing { get; set; }
        public DbSet<jewlery_template> jewlery_template { get; set; }
    }
}
