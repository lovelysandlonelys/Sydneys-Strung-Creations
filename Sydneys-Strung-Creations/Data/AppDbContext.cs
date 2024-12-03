using Microsoft.EntityFrameworkCore;

namespace Sydneys_Strung_Creations.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
