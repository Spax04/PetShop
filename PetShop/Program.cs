

using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Repositories;

 var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, PetRepository>();
string connectionString = builder.Configuration["ConnectionString:DefaultConnection"];
builder.Services.AddDbContext<StoreContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<StoreContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{

    endpoints.MapDefaultControllerRoute();

});



app.Run();
