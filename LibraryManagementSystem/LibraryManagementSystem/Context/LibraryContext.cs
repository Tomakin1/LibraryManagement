using LibraryManagementSystem.Models;
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



            //USER 

            modelBuilder.Entity<User>().HasKey(u => u.Id);

            modelBuilder.Entity<User>().Property(u => u.Firstname)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>().Property(u => u.Lastname)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>().HasMany(u => u.Books)
                .WithMany(b => b.Users)
                .UsingEntity(j => j.ToTable("usersBooks"));

            modelBuilder.Entity<User>().HasOne(u => u.UserDetail)
                .WithOne(x => x.User)
                .HasForeignKey<UserDetail>(x => x.UserId);


            modelBuilder.Entity<User>().HasData(

                new User { Id = 1, Firstname = "Ömer", Lastname = "Tomakin" },
new User { Id = 2, Firstname = "Ayşe", Lastname = "Yılmaz" },
new User { Id = 3, Firstname = "Mehmet", Lastname = "Kaya" },
new User { Id = 4, Firstname = "Elif", Lastname = "Demir" },
new User { Id = 5, Firstname = "Hasan", Lastname = "Çelik" },
new User { Id = 6, Firstname = "Zeynep", Lastname = "Koç" },
new User { Id = 7, Firstname = "Ali", Lastname = "Şahin" },
new User { Id = 8, Firstname = "Fatma", Lastname = "Öztürk" },
new User { Id = 9, Firstname = "Emre", Lastname = "Arslan" },
new User { Id = 10, Firstname = "Selin", Lastname = "Yıldırım" },
new User { Id = 11, Firstname = "Burak", Lastname = "Eren" },
new User { Id = 12, Firstname = "Gizem", Lastname = "Aksoy" },
new User { Id = 13, Firstname = "Yusuf", Lastname = "Taş" },
new User { Id = 14, Firstname = "Buse", Lastname = "Kurt" },
new User { Id = 15, Firstname = "Deniz", Lastname = "Aslan" }


            );

            modelBuilder.Entity<User>().HasMany(u => u.Books)
                .WithMany(b => b.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "usersBooks",
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasData(
                            new { UserId = 1, BookId = 1 },
                            new { UserId = 2, BookId = 2 },
                            new { UserId = 3, BookId = 3 },
                            new { UserId = 4, BookId = 4 },
                            new { UserId = 5, BookId = 5 },
                            new { UserId = 6, BookId = 6 },
                            new { UserId = 7, BookId = 7 },
                            new { UserId = 8, BookId = 8 },
                            new { UserId = 9, BookId = 9 },
                            new { UserId = 10, BookId = 10 },
                            new { UserId = 11, BookId = 11 },
                            new { UserId = 12, BookId = 12 },
                            new { UserId = 13, BookId = 13 },
                            new { UserId = 14, BookId = 14 },
                            new { UserId = 15, BookId = 15 }

                        );
                    }
                );

            // USER DETAİLS


            modelBuilder.Entity<UserDetail>().HasKey(x => x.Id);

            modelBuilder.Entity<UserDetail>().Property(u => u.Address)
                .IsRequired(false)
                .HasMaxLength(300);

            modelBuilder.Entity<UserDetail>().Property(u => u.Age)
           .IsRequired(false);

            modelBuilder.Entity<UserDetail>().Property(u => u.CategoryChoice)
           .IsRequired(false)
           .HasMaxLength(50);


            modelBuilder.Entity<UserDetail>().HasData(

    new UserDetail { Id = 1, Address = "Çekmeköy/İstanbul", Age = 20, CategoryChoice = "Roman", UserId = 1 },
new UserDetail { Id = 2, Address = "Kadıköy/İstanbul", Age = 25, CategoryChoice = "Bilim Kurgu", UserId = 2 },
new UserDetail { Id = 3, Address = "Beşiktaş/İstanbul", Age = 22, CategoryChoice = "Polisiye", UserId = 3 },
new UserDetail { Id = 4, Address = "Bornova/İzmir", Age = 28, CategoryChoice = "Tarih", UserId = 4 },
new UserDetail { Id = 5, Address = "Osmangazi/Bursa", Age = 30, CategoryChoice = "Macera", UserId = 5 },
new UserDetail { Id = 6, Address = "Konak/İzmir", Age = 27, CategoryChoice = "Korku", UserId = 6 },
new UserDetail { Id = 7, Address = "Keçiören/Ankara", Age = 21, CategoryChoice = "Biyografi", UserId = 7 },
new UserDetail { Id = 8, Address = "Şahinbey/Gaziantep", Age = 29, CategoryChoice = "Felsefe", UserId = 8 },
new UserDetail { Id = 9, Address = "Odunpazarı/Eskişehir", Age = 24, CategoryChoice = "Psikoloji", UserId = 9 },
new UserDetail { Id = 10, Address = "Melikgazi/Kayseri", Age = 32, CategoryChoice = "Klasik", UserId = 10 },
new UserDetail { Id = 11, Address = "Eyyübiye/Şanlıurfa", Age = 23, CategoryChoice = "Şiir", UserId = 11 },
new UserDetail { Id = 12, Address = "Mamak/Ankara", Age = 26, CategoryChoice = "Edebiyat", UserId = 12 },
new UserDetail { Id = 13, Address = "Büyükçekmece/İstanbul", Age = 31, CategoryChoice = "Tarih", UserId = 13 },
new UserDetail { Id = 14, Address = "Seyhan/Adana", Age = 22, CategoryChoice = "Bilim", UserId = 14 },
new UserDetail { Id = 15, Address = "Ortahisar/Trabzon", Age = 28, CategoryChoice = "Fantastik", UserId = 15 }



            );


              //  BOOK

             modelBuilder.Entity<Book>().HasKey(x => x.Id);

            modelBuilder.Entity<Book>().Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Book>().Property(b => b.Category)
           .IsRequired(false)
           .HasMaxLength(50);

            modelBuilder.Entity<Book>().HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Entity<Book>().HasData(

   new Book { Id = 1, Name = "Portakal Ağacı", Category = "Roman", Price = 120, AuthorId = 1 },
new Book { Id = 2, Name = "Beyaz Kale", Category = "Tarih", Price = 150, AuthorId = 2 },
new Book { Id = 3, Name = "Aşk", Category = "Roman", Price = 130, AuthorId = 3 },
new Book { Id = 4, Name = "İstanbul Hatırası", Category = "Polisiye", Price = 140, AuthorId = 4 },
new Book { Id = 5, Name = "Kırk Ambar", Category = "Tarih", Price = 160, AuthorId = 5 },
new Book { Id = 6, Name = "Kürk Mantolu Madonna", Category = "Roman", Price = 110, AuthorId = 6 },
new Book { Id = 7, Name = "İnce Memed", Category = "Macera", Price = 170, AuthorId = 7 },
new Book { Id = 8, Name = "Serenad", Category = "Dram", Price = 125, AuthorId = 8 },
new Book { Id = 9, Name = "Ateşten Gömlek", Category = "Tarih", Price = 135, AuthorId = 9 },
new Book { Id = 10, Name = "Çalıkuşu", Category = "Roman", Price = 145, AuthorId = 10 },
new Book { Id = 11, Name = "Az", Category = "Psikoloji", Price = 155, AuthorId = 11 },
new Book { Id = 12, Name = "Füreya", Category = "Biyografi", Price = 165, AuthorId = 12 },
new Book { Id = 13, Name = "Gün Olur Asra Bedel", Category = "Roman", Price = 175, AuthorId = 13 },
new Book { Id = 14, Name = "Suç ve Ceza", Category = "Klasik", Price = 180, AuthorId = 14 },
new Book { Id = 15, Name = "Satranç", Category = "Klasik", Price = 190, AuthorId = 15 }


            );


            //  AUTHOR 



            modelBuilder.Entity<Author>().HasKey(x => x.Id);

            modelBuilder.Entity<Author>().Property(a => a.Firstname)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Author>().Property(a => a.Lastname)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Author>().HasData(

                new Author { Id = 1, Firstname = "Altay", Lastname = "Tarkan" },
new Author { Id = 2, Firstname = "Orhan", Lastname = "Pamuk" },
new Author { Id = 3, Firstname = "Elif", Lastname = "Şafak" },
new Author { Id = 4, Firstname = "Ahmet", Lastname = "Ümit" },
new Author { Id = 5, Firstname = "İlber", Lastname = "Ortaylı" },
new Author { Id = 6, Firstname = "Sabahattin", Lastname = "Ali" },
new Author { Id = 7, Firstname = "Yaşar", Lastname = "Kemal" },
new Author { Id = 8, Firstname = "Zülfü", Lastname = "Livaneli" },
new Author { Id = 9, Firstname = "Halide Edib", Lastname = "Adıvar" },
new Author { Id = 10, Firstname = "Reşat Nuri", Lastname = "Güntekin" },
new Author { Id = 11, Firstname = "Hakan", Lastname = "Günday" },
new Author { Id = 12, Firstname = "Ayşe", Lastname = "Kulin" },
new Author { Id = 13, Firstname = "Cengiz", Lastname = "Aytmatov" },
new Author { Id = 14, Firstname = "Dostoyevski", Lastname = "Fyodor" },
new Author { Id = 15, Firstname = "Stefan", Lastname = "Zweig" }

            );












        }

    }
}
