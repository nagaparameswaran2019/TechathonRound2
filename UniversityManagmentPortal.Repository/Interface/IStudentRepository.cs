using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface IStudentRepository
    {
        void AddOrUpdateStudentDetails(Student student);
        Student GetStudentDetailsById(int id);
        List<Student> GetAllStudents();
    }
}
