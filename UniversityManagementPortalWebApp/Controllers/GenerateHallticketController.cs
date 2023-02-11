using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class GenerateHallticketController : Controller
    {
        // GET: GenerateHallticketController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenerateHallticketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenerateHallticketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenerateHallticketController/Create
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

        // GET: GenerateHallticketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenerateHallticketController/Edit/5
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

        // GET: GenerateHallticketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenerateHallticketController/Delete/5
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
