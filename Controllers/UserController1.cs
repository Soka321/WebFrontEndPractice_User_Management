using Microsoft.AspNetCore.Mvc;
using WebFrontEndPractice.Services;

namespace WebFrontEndPractice.Controllers
{
    public class UserController1 : Controller
    {
        private readonly IUserService _service;
        public UserController1(IUserService service) { _service = service; }

        [HttpGet("Users")]
        public Task<ActionResult> GetUsers()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
