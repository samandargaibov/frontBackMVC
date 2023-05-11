using Microsoft.AspNetCore.Mvc;

namespace TemplateFrontASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
