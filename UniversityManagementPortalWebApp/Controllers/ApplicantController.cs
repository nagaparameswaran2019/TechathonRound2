using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.Service.Service;
using UniversityManagementPortal.UIModel;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ILookUpGroupService _lookUpGroupService;
        private readonly IUserService _userService;
        public ApplicantController(IStudentService studentService, ILookUpGroupService lookUpGroupService, IUserService userService)
        {
            _studentService = studentService;
            _lookUpGroupService = lookUpGroupService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            ApplicantViewModel applicantViewModel = new ApplicantViewModel();
            var lookups = _lookUpGroupService.GetLookupGroupByName("PGPR,UGPR");
            applicantViewModel.PGProgramList = lookups.Data.FirstOrDefault(s => s.Code == "PGPR").LookUps.ToList();
            applicantViewModel.UGProgramList = lookups.Data.FirstOrDefault(s => s.Code == "UGPR").LookUps.ToList();

            applicantViewModel.UniversityList = _userService.GetAllUserLookupByRoleId("100" /*Admin*/);

            applicantViewModel.GraduationType = new List<SelectListItem>() {
                new SelectListItem(){ Value="PG", Text="Post Graduate"},
                new SelectListItem(){ Value="UG", Text="Under Graduate"}
            };
            return View(applicantViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ApplicantViewModel applicantViewModel)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    _studentService.AddApplicantDetails(applicantViewModel);
                    var lookups = _lookUpGroupService.GetLookupGroupByName("PGPR,UGPR");
                    applicantViewModel.PGProgramList = lookups.Data.FirstOrDefault(s => s.Code == "PGPR").LookUps.ToList();
                    applicantViewModel.UGProgramList = lookups.Data.FirstOrDefault(s => s.Code == "UGPR").LookUps.ToList();
                    applicantViewModel.UniversityList = _userService.GetAllUserLookupByRoleId("100" /*Admin*/);
                    applicantViewModel.GraduationType = new List<SelectListItem>() {
                        new SelectListItem(){ Value="PG", Text="Post Graduate"},
                        new SelectListItem(){ Value="UG", Text="Under Graduate"}
                };
                }
            }
            catch (Exception ex)
            {
            }
            return View(applicantViewModel);
        }


    }
}
