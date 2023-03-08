using Microsoft.EntityFrameworkCore;

namespace crud2.Models
{
    public class _DbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyStore2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}