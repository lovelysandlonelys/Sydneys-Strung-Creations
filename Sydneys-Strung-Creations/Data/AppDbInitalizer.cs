using Sydneys_Strung_Creations.Data.Enums;
using Sydneys_Strung_Creations.Models;

namespace Sydneys_Strung_Creations.Data
{
    public class AppDbInitalizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Gallery Listings
                if (!context.gallary_listing.Any())
                {
                    context.gallary_listing.AddRange(new List<gallary_listing>()
                    {
                        new gallary_listing()
                        {
                            JewleryPictureURL = "blah",
                            ProductName = "help",
                            ProductDescription = "uhg",
                            JewleryCategory = JewleryCategory.Bracelet
                        }
                    });
                }
                //Template Listings
                if (!context.jewlery_template.Any())
                {

                }
            }
        }
    }
}
