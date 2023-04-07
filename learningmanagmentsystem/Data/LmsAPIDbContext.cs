using Microsoft.EntityFrameworkCore;
using learningmanagmentsystem.Model;

namespace learningmanagmentsystem.Data
{
    public class LmsAPIDbContext : DbContext
    {
        public LmsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Home> hometable { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Home>().HasKey(e => e.id);
        }
    }
}
