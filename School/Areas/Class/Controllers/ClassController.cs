using Microsoft.AspNetCore.Mvc;

namespace School.Areas.Class.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            // Duong khai Cuong
            return View();
        }
    }
}
