using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementPortal.UIModel;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortal.Service.Interface
{
    public interface IExamService
    {
        List<ExamViewModel> GetAllExma(string programCode, string semeseterCode, string yearCode);
        void AddOrUpdateExam(List<ExamViewModel> exam);
    }
}
