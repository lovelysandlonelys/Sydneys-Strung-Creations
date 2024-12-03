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
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/black-red-heart-bracelet.jpg",
                            ProductName = "Black and Red Heart Bracelet",
                            ProductDescription = "A metal link bracelet with a magnetic heart clasp.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-bar-bracelet.jpg",
                            ProductName = "Blue Bar Bracelet",
                            ProductDescription = "A braclet following the bar template in dark blue, light blue, and clear beads.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-bird-necklace.jpg",
                            ProductName = "Blue Bird Necklace",
                            ProductDescription = "A necklace with light blue, dark blue, and white beads and silver hardware.There are five silver birds dangling at various points throughout the necklace",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-bird-necklace-2.jpg",
                            ProductName = "Blue Bird Necklace",
                            ProductDescription = "A necklace with light blue, dark blue, and white beads and silver hardware.There are five silver birds dangling at various points throughout the necklace",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-cross-bracelet-set.jpg",
                            ProductName = "Blue Cross Bracelets",
                            ProductDescription = "Two cross style bracelets in various shades of blue and white.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-fish-necklace.jpg",
                            ProductName = "Blue Fish Necklace",
                            ProductDescription = "A necklace with silver hardware and blue beads. There are blue fish beads along the necklace as the centerpeice.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-pink-bracelet-set.jpg",
                            ProductName = "Pink Circle Bracelet and Blue Wave Bracelet",
                            ProductDescription = "Two braclets in differnt styles, one pink and one blue and white.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-smile-necklace.jpg",
                            ProductName = "Blue Bird Necklace",
                            ProductDescription = "A necklace with light blue, dark blue, and white beads and silver hardware.There are two distinct strings of beads both leading to a light blue smile bead as the centerpeice.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-swirl-necklace.jpg",
                            ProductName = "Blue Swirl Necklace",
                            ProductDescription = "A necklace with dark blue beads and silver hardware. The centerpeice bead is ceramic and painted with a swirl.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/blue-white-cross-bar-bracelet.jpg",
                            ProductName = "Teal and White Cross Bar Bracelet",
                            ProductDescription = "A Bracelet following the cross bar pattern with teal, purple, and white beads.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.White
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/brown-flower-necklace.jpg",
                            ProductName = "Brown Flower Necklace",
                            ProductDescription = "A necklace with brown and cream beads, the centerpeice is a wooden flower, and there are two loops of chain with beads framing the flower.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Brown
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/bunny-soup-set.jpg",
                            ProductName = "Soup Set",
                            ProductDescription = "A set of a necklace and earrings featuring red, oragne, yellow, and green beads. The centerpeice of each item is a cinimaroll bunny charm eating watermellon.",
                            JewleryCategory = JewleryCategory.Set,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/character-bracelet-set.jpg",
                            ProductName = "Character Inspired Bracelets",
                            ProductDescription = "A set of four bracelets each inspired by differnt characters.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Mixed
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/dangle-braclet-set.jpg",
                            ProductName = "Pink and Purple Braclet Set",
                            ProductDescription = "A set of four bracelets, one purple with hearts, one pink and orage with stars, one black and purple with flowers, and the last pink and white with dangling hearts.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Mixed
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/dark-blue-necklace.jpg",
                            ProductName = "Dark Blue Flower and Swirl Necklace",
                            ProductDescription = "A necklace with dark blue beads and gold hardware. The centerpeie is a ceramic swirl bead framed by two dangling flowers.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-bar-bracelet.jpg",
                            ProductName = "Gold Bar Bracelet",
                            ProductDescription = "A bracelet with white, blue, and gold beads in the bar template.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Gold
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-dangle-earrings.jpg",
                            ProductName = "Gold Flower Dangle Earrings",
                            ProductDescription = "A Set of earrings with gold hardware and purple dangling flowers. There are three near the top of the earrings and one hanging lower down, giving the earrings some length.",
                            JewleryCategory = JewleryCategory.Earring,
                            FocalColor = FocalColor.Gold
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-red-chain-bracelet.jpg",
                            ProductName = "Chain Loop Bracelet",
                            ProductDescription = "A bracelet with with a simple stirng of beads alternating between gold and red, there are loops of gold chain hanging under each red bead.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Gold
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-red-heart-bracelet.jpg",
                            ProductName = "Gold and Red Heart Bracelet",
                            ProductDescription = "A bracelet with red, white, and gold beads with a heart clasp.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-rose-necklace.jpg",
                            ProductName = "Roses and Pearls Necklace",
                            ProductDescription = "A necklace with gold hardware and red beads. There are bearl beads and red rose flowers at various places.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/gold-rose-necklace-2.jpg",
                            ProductName = "Roses and Pearls Necklace",
                            ProductDescription = "A necklace with gold hardware and red beads. There are bearl beads and red rose flowers at various places.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/green-sword-necklace.jpg",
                            ProductName = "Green Sword Necklace",
                            ProductDescription = "A necklace with silver hardware and green and silver beads. The centerpeice is a silver sword charm.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Green
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/green-sword-necklace-2.jpg",
                            ProductName = "Green Sword Necklace",
                            ProductDescription = "A necklace with silver hardware and green and silver beads. The centerpeice is a silver sword charm.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Green
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/lilllypad-necklace.jpg",
                            ProductName = "Lillypad Necklace",
                            ProductDescription = "A necklace with green and pink beads and silver hardware. The necklace has many loops of green beads going around the central pink strand, ad danglin gpink flowers in the front.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/lilllypad-necklace-2.jpg",
                            ProductName = "Lillypad Necklace",
                            ProductDescription = "A necklace with green and pink beads and silver hardware. The necklace has many loops of green beads going around the central pink strand, ad danglin gpink flowers in the front.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/miku-necklace.jpg",
                            ProductName = "Hatsume Miku Necklace",
                            ProductDescription = "A necklace teal and black beads. There are two strand connected with a clasp so that the necklaces can be worn as a layered peice or on their own. There is a hand drawn Hatsume Miku charm at the center.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Blue
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/orange-fish-necklace.jpg",
                            ProductName = "Orange Fish Necklace",
                            ProductDescription = "A necklace with orange beads and silver hardware. There are orange fish beads as the focal point.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Orange
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/orange-set.jpg",
                            ProductName = "Sunrise Necklace Set",
                            ProductDescription = "A matching set of earrings and a layered necklace in red, orange, and yellow beads.",
                            JewleryCategory = JewleryCategory.Set,
                            FocalColor = FocalColor.Orange
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-cross-bracelet.jpg",
                            ProductName = "Lillypad Bracelet",
                            ProductDescription = "A braclet in the cross template with green, pink, and clear beads.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-flower-dangle-set.jpg",
                            ProductName = "Pink Bell Fower Set",
                            ProductDescription = "A matching pair of earings and a necklace. Both use gold hardware with pink bell flowers as the focal point.",
                            JewleryCategory = JewleryCategory.Set,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-grate-necklace.jpg",
                            ProductName = "Pink Ladder Necklace",
                            ProductDescription = "A pink necklace with silver hardwar in the ladder template.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-green-flower-necklace.jpg",
                            ProductName = "Pink Dangle Bracelet",
                            ProductDescription = "A string bracelt featuring pink and teal beads with small dangles and heart clasps.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-necklace-ring-set.jpg",
                            ProductName = "Babydoll Braclet Set",
                            ProductDescription = "A set of matching bracelet and rings in pastal pinks and purples.",
                            JewleryCategory = JewleryCategory.Set,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/pink-teal-set.jpg",
                            ProductName = "Pink, Red, and Teal Set",
                            ProductDescription = "A set of two pairs of earrings and a braclet with pink, white, teal, and red beads.",
                            JewleryCategory = JewleryCategory.Set,
                            FocalColor = FocalColor.Pink
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-acorn-necklace.jpg",
                            ProductName = "Purple Pinecone Necklace",
                            ProductDescription = "A necklace with purple beads and bronze hardware featuring acorn and pinecone charms.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-acorn-necklace-2.jpg",
                            ProductName = "Purple Pinecone Necklace",
                            ProductDescription = "A necklace with purple beads and bronze hardware featuring acorn and pinecone charms.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-gold-necklace.jpg",
                            ProductName = "Purple Gold Necklace",
                            ProductDescription = "A necklace with purple and pink beads and gold hardware featuring some flower dangles.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-grate-necklace.jpg",
                            ProductName = "Purple Ladder Necklace",
                            ProductDescription = "A necklace with purple beads adone in the ladder style.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-grate-necklace-2.jpg",
                            ProductName = "Purple Ladder Necklace",
                            ProductDescription = "A necklace with purple beads adone in the ladder style.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/purple-heart-bracelet.jpg",
                            ProductName = "Purple Heart Bracelet",
                            ProductDescription = "A bracelet in the circle syle with hearts as the connecting beads, mainly silver with purple accents.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Purple
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/red-black-necklace.jpg",
                            ProductName = "Vampire Necklace",
                            ProductDescription = "A necklace with red beads and black hardware. The centerpeice is a black heart wich also serves as a magnetic clasp.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/saftey-pin-necklace.jpg",
                            ProductName = "Saftey Pin Necklace",
                            ProductDescription = "A necklace made of saftey pins with black and gray beads on the long pins.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Silver
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/star-bracelet.jpg",
                            ProductName = "Star Dangle Bracelet",
                            ProductDescription = "A bracelet with red, coral, and black beads and silver hardware. The bracelet has coral star dangles.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Red
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/star-dangle-bracelet.jpg",
                            ProductName = "Clear Star Dangle Bracelet",
                            ProductDescription = "A bracelet with red, coral, and clear beads and gold hardware. The bracelet has clear star dangles.",
                            JewleryCategory = JewleryCategory.Bracelet,
                            FocalColor = FocalColor.Orange
                        },
                        new gallary_listing
                        {
                            JewleryPicturePath = "/images/star-dangle-necklace.jpg",
                            ProductName = "Star Dangle Necklace",
                            ProductDescription = "A necklace with red, coral, and black beads and silver hardware. The necklace has star dangles on silver chain.",
                            JewleryCategory = JewleryCategory.Necklace,
                            FocalColor = FocalColor.Red
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
