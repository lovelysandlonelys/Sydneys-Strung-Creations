using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sydneys_Strung_Creations.Data;
using Sydneys_Strung_Creations.Data.Services;
using Sydneys_Strung_Creations.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
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

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Seed the database
AppDbInitalizer.Seed(app);
AppDbInitalizer.SeedUsersAndRolesAsync(app);

app.Run();
