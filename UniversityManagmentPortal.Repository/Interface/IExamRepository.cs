using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Common;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface IExamRepository
    {
        List<Exam> GetAllExma(string programCode, string semeseterCode, string yearCode);
        void AddOrUpdateExam(Exam exam);
    }
}
