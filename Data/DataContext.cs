using ecommerce_api.Models;
using Microsoft.EntityFrameworkCore;    

namespace ecommerce_api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
      
        }
        public DbSet<logininfo> logininfos{ get; set; }
        public DbSet<Storeitems> storeitems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<logininfo>().HasKey(X => new { X.FirstName, X.LastName, X.Password });
        }
    }
}
