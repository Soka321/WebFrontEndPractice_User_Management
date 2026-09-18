using Microsoft.AspNetCore.Mvc;
using WebFrontEndPractice.Models;
using WebFrontEndPractice.Models.DTOs;
using WebFrontEndPractice.Services;

namespace WebFrontEndPractice.Controllers
{
    public class UserController1 : Controller
    {
        private readonly IUserService _service;
        public UserController1(IUserService service) { _service = service; }

        [HttpGet("Users")]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _service.GetAllUsers();
                if (users != null)
                {
                    return View(users);
                }
                return NotFound("No users found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET view for login page
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto user)
        {
            try
            {
                var responseTask = _service.LoginUser(user);
                if (responseTask != null)
                {
                    var response = responseTask.Result;
                    var token = response.AccessToken;
                    HttpContext.Session.SetString("Token", token);
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET view for add-user page
        [HttpGet("AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                _service.AddSingleUser(user);
                return RedirectToAction("GetUsers");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}