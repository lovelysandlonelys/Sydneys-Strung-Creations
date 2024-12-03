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
                    context.gallary_listing.AddRange(new List<gallary_listing>
                    {
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/black-red-cross-bracelet.jpg",
                            ProductName = "Black and Red Cross Bracelet",
                            ProductDescription = "A braclet following the cross template in black, read, and clear beads.",
                            JewleryCategory = JewleryCategory.Bracelet
                        }
                    });
                    context.SaveChanges();
                }
                //Template Listings
                if (!context.jewlery_template.Any())
                {

                }
            }
        }
    }
}
