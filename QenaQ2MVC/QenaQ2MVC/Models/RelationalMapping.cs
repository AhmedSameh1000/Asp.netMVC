using Microsoft.EntityFrameworkCore;

namespace QenaQ2MVC.Models
{
    public static class RelationalMapping
    {
        public static void MapRelationship(this ModelBuilder builder)
        {
            builder.Entity<Book>().HasOne(a => a.Author).
                WithMany(a => a.Books).
                HasForeignKey(i => i.AuthorID).
                IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<BookImage>().HasOne(a => a.Book).
                WithMany(a => a.BookImages).HasForeignKey(a => a.BookID).
                IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
