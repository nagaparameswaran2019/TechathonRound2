using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class GenerateDegreeController : Controller
    {
        // GET: GenerateDegreeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenerateDegreeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenerateDegreeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenerateDegreeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenerateDegreeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenerateDegreeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenerateDegreeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenerateDegreeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
