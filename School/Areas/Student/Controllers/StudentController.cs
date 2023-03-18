using Microsoft.AspNetCore.Mvc;

namespace School.Areas.Student.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
