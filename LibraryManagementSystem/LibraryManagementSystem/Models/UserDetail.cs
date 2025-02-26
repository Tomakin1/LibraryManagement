namespace LibraryManagementSystem.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
        public string? CategoryChoice { get; set; }


        public int UserId { get; set; }
        public virtual User User { get; set; } = default!;


    }
}
