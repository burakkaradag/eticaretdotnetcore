using ETicaret.ENT;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace ETicaret.DAL
{
    public class ETicaretContext : IdentityDbContext<IdentityUser>
    {
       
        public ETicaretContext(DbContextOptions<ETicaretContext> option) : base(option)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ETicaretDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }

   

}
