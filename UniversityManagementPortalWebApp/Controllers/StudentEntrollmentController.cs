using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityMgmtUtil;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class StudentEntrollmentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentEntrollmentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public ActionResult ApplicantEntrolment()
        {
            var user = this.User.GetUserId();
            _studentService.GetAllApplicantsByUniveristyId(user);
            return View();
        }

        [HttpGet]
        public JsonResult GetAllApplicantByUniveristyId()
        {
            var user = this.User.GetUserId();
            var result = _studentService.GetAllApplicantsByUniveristyId(user);
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> StudentEntrolment(StudentViewModel studentViewModel)
        {
            try
            {

                var result = await _studentService.AddOrUpdateStudentDetails(studentViewModel);

                if (!result.IsSuccess)
                {
                    ModelState.AddModelError("Error", result.Message);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
            }
            return View(studentViewModel);
        }

        // GET: Student
        public ActionResult Index()
        {
            List<StudentViewModel> result = _studentService.GetAllStudents();
            return View(result);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
