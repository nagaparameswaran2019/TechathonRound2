using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.Service.Interface
{
    public interface IStudentService
    {
        Task<Result<StudentViewModel>> AddOrUpdateStudentDetails(StudentViewModel student);
        StudentViewModel GetStudentDetailsById(int id);
        List<StudentViewModel> GetAllStudents();
    }
}
