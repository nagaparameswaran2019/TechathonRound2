using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
