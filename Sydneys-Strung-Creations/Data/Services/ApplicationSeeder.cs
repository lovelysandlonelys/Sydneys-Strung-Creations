using Microsoft.AspNetCore.Identity;
using Sydneys_Strung_Creations.Data.Static;
using Sydneys_Strung_Creations.Models;

public class ApplicationSeeder
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public ApplicationSeeder(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task SeedAdminUserAsync()
    {
        var adminEmail = "admin@example.com"; // Change to your desired admin email
        var adminPassword = "Admin@123"; // Set a strong password for the admin

        var adminUser = await _userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            // Create the admin user
            adminUser = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FullName = "Admin User" // Set admin's full name
            };

            var createResult = await _userManager.CreateAsync(adminUser, adminPassword);

            if (createResult.Succeeded)
            {
                // Assign the user to the Admin role (if it doesn't already exist)
                var roleExist = await _roleManager.RoleExistsAsync(UserRoles.Admin);
                if (!roleExist)
                {
                    var roleResult = await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                    if (!roleResult.Succeeded)
                    {
                        // Handle role creation failure (optional)
                        throw new Exception("Failed to create Admin role.");
                    }
                }

                await _userManager.AddToRoleAsync(adminUser, UserRoles.Admin);
            }
            else
            {
                // Handle user creation failure (optional)
                throw new Exception("Failed to create admin user.");
            }
        }
    }
}
