using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.Service.Interface;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.Service.Service
{
    public class StudentService : IStudentService
    {
        public void AddOrUpdateStudentDetails(StudentViewModel student)
        {
            var studentData = new Student();
            
        }

        public List<StudentViewModel> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public StudentViewModel GetStudentDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
