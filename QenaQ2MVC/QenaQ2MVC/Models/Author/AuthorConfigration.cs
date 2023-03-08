using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QenaQ2MVC.Models
{
    public class AuthorConfigration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired().
                HasMaxLength(100).HasColumnName("NameOfAuthor");
        }
    }
}
