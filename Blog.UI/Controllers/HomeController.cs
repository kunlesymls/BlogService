using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}