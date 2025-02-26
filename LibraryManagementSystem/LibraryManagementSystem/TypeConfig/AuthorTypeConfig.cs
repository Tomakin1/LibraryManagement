using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.TypeConfig
{
    public class AuthorTypeConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a=>a.Firstname)
                .IsRequired()
                .HasMaxLength(50);
                 
            builder.Property(a=>a.Lastname)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(

                new Author { Id = 1, Firstname = "Altay", Lastname = "Tarkan" }
            );
        }
    }
}
