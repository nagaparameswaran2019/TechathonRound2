using UniversityManagementPortalEntity.Model;
using UniversityManagmentPortal.Repository.Common;

namespace UniversityManagmentPortal.Repository.Interface
{
    public interface ISemesterMasterRepository
    {
        List<SemesterMaster> GetSubjectBySemester(string programCode, string semeseterCode, string yearCode);
    }
}
