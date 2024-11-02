using Blood_Donation_Backend.Data;
using Blood_Donation_Backend.Models;
using Blood_Donation_Backend.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blood_Donation_Backend.Controllers
{
    // localhost:xxxx/api/users
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpPost]
        public IActionResult AddUser(AddUserDto addUserDto)
        {

            var userEntity = new User()
            {
                Name = addUserDto.Name,
                Email = addUserDto.Email,
                Mobile = addUserDto.Mobile,
                Address = addUserDto.Address,
                BloodGroup = addUserDto.BloodGroup,
            };

            _context.Users.Add(userEntity);
            _context.SaveChanges();

            return Ok(userEntity);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateUser(Guid id, UpdateUserDto updateUserDto)
        {

            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            user.Name = updateUserDto.Name;
            user.Email = updateUserDto.Email;
            user.Mobile = updateUserDto.Mobile;
            user.Address = updateUserDto.Address;
            user.BloodGroup = updateUserDto.BloodGroup;

            _context.SaveChanges();
            return Ok(user);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteUserById(Guid id)
        {
            var user = _context.Users.Find(id);

            if(user == null) 
            { 
                return NotFound(); 
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok();

        }
    } 
}
