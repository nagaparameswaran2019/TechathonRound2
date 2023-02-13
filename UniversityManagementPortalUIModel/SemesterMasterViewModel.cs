using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortal.UIModel
{
    public class SemesterMasterViewModel
    {
        public int Id { get; set; }
        public string SemeseterCode { get; set; }
        public string Semeseter { get; set; }
        public string SubjectCode { get; set; }
        public string Subject { get; set; }
        public string YearCode { get; set; }
        public string Year { get; set; }
        public string ProgramCode { get; set; }
        public string Program { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamSession { get; set; }
        public string ExamSlot { get;set; }
    }
}
