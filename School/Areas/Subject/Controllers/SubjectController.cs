using Microsoft.AspNetCore.Mvc;

namespace School.Areas.Subject.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
