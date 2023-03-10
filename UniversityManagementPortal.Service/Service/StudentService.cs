using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.Mapper;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Interface;

namespace UniversityManagementPortal.Service.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUserManagerService _userManagerService;
        private readonly IApplicantRepository _applicantRepository;
        public StudentService(IStudentRepository studentRepository, IUserManagerService userManagerService, IApplicantRepository applicantRepository)
        {
            _studentRepository = studentRepository;
            _userManagerService = userManagerService;
            _applicantRepository = applicantRepository;
        }

        public void AddApplicantDetails(ApplicantViewModel applicant)
        {
            var model = applicant.CopyTo<Applicant>();
            _applicantRepository.AddApplicantDetails(model);
        }

        public async Task<Result<StudentViewModel>> AddOrUpdateStudentDetails(StudentViewModel student)
        {
            var model = student.CopyTo<Student>();
            model.MiddleName = "T";
            var user = await _userManagerService.CreateIndentityUser(student, "Sudent");
            if (!user.IsSuccess)
            {
                return user;
            }
            else
            {
                model.AspNetUsersId = user.Data.AspNetUsersId;
                _studentRepository.AddOrUpdateStudentDetails(model);
            }
            return new Result<StudentViewModel>("Student Added successfully", student, true);
        }

        public List<ApplicantViewModel> GetAllApplicantsByUniveristyId(string id)
        {
            List<ApplicantViewModel> applicants = new List<ApplicantViewModel>();
            var result = _applicantRepository.GetAllApplicantsByUniveristyId(id);
            applicants = result.CopyTo<List<ApplicantViewModel>>();
            return applicants;
        }

        public List<StudentViewModel> GetAllStudents()
        {
            List<StudentViewModel> students = new List<StudentViewModel>();
            var result = _studentRepository.GetAllStudents();
            students = result.CopyTo<List<StudentViewModel>>();
            return students;
        }

        public StudentViewModel GetStudentDetailsById(int id)
        {
            var result = _studentRepository.GetStudentDetailsById(id);
            StudentViewModel studentViewModel = result.CopyTo<StudentViewModel>();
            return studentViewModel;
        }
    }
}
