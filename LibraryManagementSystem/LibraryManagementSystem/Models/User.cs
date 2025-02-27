using System.Text.Json.Serialization;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; }  =default!;
        public string Fullname => Firstname + " " + Lastname;


        public virtual ICollection<Book> Books { get; set; } = new List<Book>();

        public virtual UserDetail? UserDetail { get; set; }


    }
}
