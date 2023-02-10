using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class PublishResultController : Controller
    {
        // GET: PublishResultController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PublishResultController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PublishResultController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublishResultController/Create
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

        // GET: PublishResultController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PublishResultController/Edit/5
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

        // GET: PublishResultController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PublishResultController/Delete/5
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
