using LibraryManagementSystem.Context;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repositories.Implemetations
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext _db;

        public UserRepository(LibraryContext db)
        {
            _db = db;
        }
        public List<User> Users {
            
            get { return _db.Users.ToList(); }
        }

        public void AddUser(User user)
        {
            try
            {
                if (user == null)
                    return;

                _db.Add(user);
                _db.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir Hata oluştu "+ex.Message);
            };
        }

        public void DeleteUser(int Id)
        {
            try
            {
                var DeletedUser = GetUserById(Id);

                if (DeletedUser == null)
                    Console.WriteLine("Kullanıcı Mevcut değil");

                _db.Remove(DeletedUser);
                _db.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir Hata oluştu " + ex.Message);
            }
        }

        public  List<User> GetUserWithDetails()
        {


            try
            {
                var users = _db.Users
                  .Include(u => u.UserDetail)
                  .ToList();

                if (users==null)
                {
                    Console.WriteLine("Kullanıcı Mevcut Değil");
                }

                return users;
                    

                
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public User GetUserById(int Id)
        {
            var user = Users.SingleOrDefault(a => a.Id == Id);

            return user;
        }

        public List<User> SearchUsersByName(string Name)
        {
            try
            {
                return _db.Users
                    .Where(u => u.Firstname.Equals(Name) || u.Lastname.Equals(Name)) // Equals kesin sonuç - Contains "omer" =>"Ömer","Omer","Ahmet omerli"
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
                return new List<User>(); // Hata durumunda boş liste döndür
            }
        }


        public void UpdateUser(int Id, User user)
        {

            try
            {
                var CurrentUser = GetUserById(Id);

                if (CurrentUser==null)
                    return;

                CurrentUser.Firstname = user.Firstname;
                CurrentUser.Lastname = user.Lastname;

                _db.Update(CurrentUser);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            
        }
    }
}
