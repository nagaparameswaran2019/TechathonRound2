using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class Exam
    {
        public int Id { get; set; }
        public int ExamCode { get; set; }
        public string ProgramCode { get; set; }
        public string AcademicYear { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamSession { get; set; }
        public string SubjectCode { get; set; }
        public string ExamSlot { get; set; }
        public string YearCode { get; set; }
        public string SemeseterCode { get; set; }
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; } = DateTime.Now;
    }
}
