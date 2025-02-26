namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Price { get; set; }
        public string? Category { get; set; }


        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
