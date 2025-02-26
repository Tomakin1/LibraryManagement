using LibraryManagementSystem.Models;
using LibraryManagementSystem.TypeConfig;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Context
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserDetailTypeConfig).Assembly);


        }

    }
}
