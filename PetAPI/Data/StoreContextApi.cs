using Microsoft.EntityFrameworkCore;
using PetAPI.Model;

namespace PetAPI.Data
{
    public class StoreContextApi : DbContext
    {

        public StoreContextApi(DbContextOptions<StoreContextApi> dbContext) : base(dbContext){}

        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comments>? Comments { get; set; }
    }
}
