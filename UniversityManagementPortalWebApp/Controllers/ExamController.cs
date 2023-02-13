using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using System.Collections.Generic;
using System.Text.Json;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.Service.Service;
using UniversityManagementPortal.UIModel;
using UniversityMgmtUtil;

namespace UniversityManagementPortal.WebApp.Controllers
{
    public class ExamController : Controller
    {
        private readonly ILookUpGroupService _lookUpGroupService;
        private readonly ISemesterMasterService _semesterMasterService;
        private readonly IExamService _examService;
        public ExamController(ILookUpGroupService lookUpGroupService, ISemesterMasterService semesterMasterService, IExamService examService)
        {
            _lookUpGroupService = lookUpGroupService;
            _semesterMasterService = semesterMasterService;
            _examService = examService;
        }
        public IActionResult Index()
        {
            ExamSchduler examSchduler = new ExamSchduler();
            try
            {
                string groupNameList = "PGPR,UGPR";
                var lookups = _lookUpGroupService.GetLookupGroupByName("PGPR,UGPR,YEAR,SMTR");
                var list = lookups.Data.Where(t => groupNameList.ToLower().Split(',').ToList().Any(s => s.Equals(t.Code.ToLower()))).Select(s => s.LookUps);
                List<LookUpViewModel> lookUpViewModels = new List<LookUpViewModel>();
                list.AsEnumerable().ToList().ForEach(r =>
                {
                    lookUpViewModels.AddRange(r);
                });
                examSchduler.ProgramYear = lookups.Data.Where(w => w.Code == "YEAR").Select(s => s.LookUps).FirstOrDefault();
                examSchduler.Semesters = lookups.Data.Where(w => w.Code == "SMTR").Select(s => s.LookUps).FirstOrDefault();

                examSchduler.ProgramList = lookUpViewModels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(examSchduler);
        }

        [HttpGet]
        public JsonResult GetAllSubjectBySemester(string programCode, string semeseterCode, string yearCode)
        {
            Result<List<SemesterMasterViewModel>> masterViewModels = new Result<List<SemesterMasterViewModel>>();
            try
            {
                masterViewModels.Message = "Success";
                masterViewModels.IsSuccess = true;
                masterViewModels.Data = _semesterMasterService.GetAllSubjectBySemester(programCode, semeseterCode, yearCode);
            }
            catch (Exception ex)
            {
                masterViewModels.Message = ex.Message;
                masterViewModels.IsSuccess = false;
                masterViewModels.Data = new List<SemesterMasterViewModel>();
            }
            return Json(masterViewModels.Data);
        }

        [HttpGet]
        public ActionResult AddExamDate(string models)
        {
            var inputData = JsonSerializer.Deserialize<List<ExamViewModel>>(models);
            _examService.AddOrUpdateExam(inputData);
            Result<List<SemesterMasterViewModel>> masterViewModels = new Result<List<SemesterMasterViewModel>>();
            try
            {
                masterViewModels.Message = "Success";
                masterViewModels.IsSuccess = true;
            }
            catch (Exception ex)
            {
                masterViewModels.Message = ex.Message;
                masterViewModels.IsSuccess = false;
                masterViewModels.Data = new List<SemesterMasterViewModel>();
            }
            return Json(masterViewModels.Data);
        }
    }
}
