using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MilkyContext _context;
        public UsersController(MilkyContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Authenticate(AppUser appUser)
        {
            var existingUser = _context.AppUsers.SingleOrDefault(u => u.UserName == appUser.UserName && u.Password == appUser.Password);
            if (existingUser == null)
                return Unauthorized(false);
            return Ok(true);
        }
    }
}
