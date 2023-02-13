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
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        public ExamService(IExamRepository examRepository) { 
            _examRepository = examRepository;
        }
        public void AddOrUpdateExam(List<ExamViewModel> exam)
        {
            var model = exam.CopyTo<List<Exam>>();
            _examRepository.AddOrUpdateExam(model);
        }

        public List<ExamViewModel> GetAllExma(string programCode, string semeseterCode, string yearCode)
        {
            throw new NotImplementedException();
        }
    }
}
