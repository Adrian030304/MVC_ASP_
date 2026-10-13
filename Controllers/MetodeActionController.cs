using Microsoft.AspNetCore.Mvc;

namespace MVC_Asp.Controllers
{
    public class MetodeActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
