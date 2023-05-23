using merketoaspnet.Contexts;
using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Helpers.Services;
using merketoaspnet.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


// Contexts
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

// Repositories
builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped<ContactRepo>();
builder.Services.AddScoped<AddressRepo>();
builder.Services.AddScoped<UserAddressRepo>();

// Services
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<AddressService>();



// Authentication
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.AccessDeniedPath = "/denied";
});

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
