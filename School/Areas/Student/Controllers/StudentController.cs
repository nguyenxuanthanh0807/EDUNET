using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Areas.Student.Controllers
{
    [Area("Student")]
    public class StudentController : Controller
    {
        private DatabaseContext context;
        public StudentController(DatabaseContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
