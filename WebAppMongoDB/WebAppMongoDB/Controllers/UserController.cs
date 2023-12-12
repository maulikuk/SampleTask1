using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAppMongoDB.Models;
using WebAppMongoDB.Services;

namespace WebAppMongoDB.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService) => _userService = userService;

        [HttpGet]
        public async Task<List<User>> Get() => await _userService.GetAsync();

        [HttpPost]
        public async Task<IActionResult> Post(User newUser)
        {
            await _userService.CreateAsync(newUser);

            return NoContent();
        }
    }
}
