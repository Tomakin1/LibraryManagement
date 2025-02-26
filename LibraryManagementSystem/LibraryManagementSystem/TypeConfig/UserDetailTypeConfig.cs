using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.TypeConfig
{
    public class UserDetailTypeConfig : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
           builder.HasKey(x => x.Id);
            
           builder.Property(u=>u.Address)
                .IsRequired(false)
                .HasMaxLength(300);

                 builder.Property(u=>u.Age)
                .IsRequired(false);
                
                 builder.Property(u=>u.CategoryChoice)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.HasData(

                new UserDetail { Id=1,Address="qweqweqwdqwq", Age=20,CategoryChoice= "Roman",UserId=1 }


            );
        }
    }
}
