using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
          
            return View();
        }
        public IActionResult ContactUs() 
        { 
            return View();
        }
    }
}
