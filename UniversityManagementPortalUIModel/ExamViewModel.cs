using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortal.UIModel
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        public string? ExamCode { get; set; }
        public string ProgramCode { get; set; }
        public string AcademicYear { get; set; }
        public DateTime? ExamDate { get; set; }
        public string ExamSession { get; set; }
        public string SubjectCode { get; set; }
        public string ExamSlot { get; set; }
        public string YearCode { get; set; }
        public string SemeseterCode { get; set; }
    }
}
