using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IUserRepository
    {
         public void AddUser(User user);
         public void DeleteUser(int Id);
         public void UpdateUser(int Id,User user);
         List<User> Users { get; }
         List<User> SearchUsersByName(string Name);
         List<User> GetUserWithDetails();
         public User GetUserById(int Id);
         

    }
}
