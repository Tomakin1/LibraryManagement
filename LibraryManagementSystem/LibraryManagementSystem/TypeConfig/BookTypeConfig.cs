using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.TypeConfig
{
    public class BookTypeConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b=>b.Name)
                .IsRequired()
                .HasMaxLength(50);

                 builder.Property(b=>b.Category)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.AuthorId);

            builder.HasData(

               new Book { Id = 1, Name = "Portakal Ağacı", Price = 120, Category = "Roman", AuthorId = 1 }
            );

        }
    }
}
