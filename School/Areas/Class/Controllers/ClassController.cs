using Microsoft.AspNetCore.Mvc;

namespace School.Areas.Class.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
