using Microsoft.AspNetCore.Mvc;
using QuickInvoice.Forms;
using QuickInvoice.Services;

namespace QuickInvoice.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet("/login")]
        public IActionResult login() 
        {
            return View();
        }

        [HttpGet("/register")]
        public IActionResult register()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult login(AuthService svc, LoginForm form)
        {

            return View();
        }

        [HttpPost("/register")]
        public IActionResult register(AuthService svc, RegistrationForm form)
        {
            return View();
        }

    }
}