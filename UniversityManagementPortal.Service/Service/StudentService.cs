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
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void AddOrUpdateStudentDetails(StudentViewModel student)
        {
            var model = student.CopyTo<Student>();
            _studentRepository.AddOrUpdateStudentDetails(model);
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
