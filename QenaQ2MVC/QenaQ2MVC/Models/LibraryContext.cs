using Microsoft.EntityFrameworkCore;

namespace QenaQ2MVC.Models
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book>Books { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<BookImage>BookImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AuthorConfigration().Configure(modelBuilder.Entity<Author>());
            new BookConfigration().Configure(modelBuilder.Entity<Book>());
            new BookImageConfigration().Configure(modelBuilder.Entity<BookImage>());
            //  modelBuilder.Entity<Book>().ToTable("");
            modelBuilder.MapRelationship();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=QenaDb; Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
