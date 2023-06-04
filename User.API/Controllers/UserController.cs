using Microsoft.AspNetCore.Mvc;

namespace User.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
