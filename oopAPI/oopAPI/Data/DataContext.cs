using Microsoft.EntityFrameworkCore;
using oopAPI.Models;

namespace oopAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {
        }
       public DbSet<Items> Items {  get; set; }   
       public DbSet<UserData> UserData { get; set; }
      public  DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserData>().HasKey(X => new { X.FirstName, X.LastName, X.Password });
        }
    }
}
