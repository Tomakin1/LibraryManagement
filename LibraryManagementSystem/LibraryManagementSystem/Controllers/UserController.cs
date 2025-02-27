using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(_repo.Users);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody]User user)
        {
            
            if (user!=null)
            {
                _repo.AddUser(user);
                return Ok(user);
            }
            return BadRequest();

        }

        [HttpDelete("{Id:int}")]
        public IActionResult DeleteUserById(int Id)
        {
                _repo.DeleteUser(Id);
            return Ok();

            
        }

        [HttpGet("{Id:int}")]
        public IActionResult GetUserWithDetails()
        {


                var users = _repo.GetUserWithDetails();

                return Ok(users);


        }

        [HttpGet("{Name}")]
        public IActionResult SearchUserByName(string Name)
        {
            if (Name!=null)
            {
                 var users=_repo.SearchUsersByName(Name);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPatch("{Id:int}")]
        public IActionResult UpdateUser(int Id, [FromBody]User user)
        {
            
            _repo.UpdateUser(Id,user);

            return Ok();           
            
        }

    }
}
