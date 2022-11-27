using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, PetRepository>();
string connectionString = builder.Configuration["ConnectionString:DefaultConnection"];
builder.Services.AddDbContext<StoreContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));
builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<StoreContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<StoreContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

app.UseAuthentication();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

    endpoints.MapDefaultControllerRoute();

});



app.Run();
