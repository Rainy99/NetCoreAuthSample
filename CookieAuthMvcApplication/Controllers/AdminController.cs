using Microsoft.AspNetCore.Mvc;

namespace CookieAuthMvcApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}