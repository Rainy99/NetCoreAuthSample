using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CookieAuthMvcApplication.Controllers
{
    [Authorize]
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