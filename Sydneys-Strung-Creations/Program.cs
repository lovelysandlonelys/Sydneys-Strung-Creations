using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Data;
using Sydneys_Strung_Creations.Data.Services;
using Sydneys_Strung_Creations.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Configure Entity Framework and SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Configure Identity Services
// Add Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

//Services Configuration
builder.Services.AddScoped<IGalleryListingService, GalleryListingService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();  // Make sure this is before UseAuthorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// seeds database
AppDbInitalizer.Seed(app);
AppDbInitalizer.SeedUsersAndRolesAsync(app).Wait();
// Seed admin user
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var seeder = new ApplicationSeeder(userManager, roleManager);
    await seeder.SeedAdminUserAsync();
}

app.Run();
