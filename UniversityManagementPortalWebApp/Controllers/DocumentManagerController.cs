using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class DocumentManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }
    }
}
