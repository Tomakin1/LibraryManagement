using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.TypeConfig
{
    public class UserTypeConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u=>u.Firstname)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Lastname)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(u => u.Books)
                .WithMany(b => b.Users)
                .UsingEntity(j => j.ToTable("usersBooks"));

            builder.HasOne(u => u.UserDetail)
                .WithOne(x => x.User)
                .HasForeignKey<UserDetail>(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(

                new User { Id=1, Firstname="Ömer",Lastname="Tomakin"}

            );

            builder.HasMany(u => u.Books)
                .WithMany(b => b.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "usersBooks",  
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasData(
                            new { UserId = 1, BookId = 1 }
                            
                        );
                    }
                );








        }
    }
}
