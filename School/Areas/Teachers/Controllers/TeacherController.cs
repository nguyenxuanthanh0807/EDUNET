using Microsoft.AspNetCore.Mvc;

namespace School.Areas.Teachers.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
