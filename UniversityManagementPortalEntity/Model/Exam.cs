using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class Exam
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string? ExamCode { get; set; }
        [StringLength(90)]
        public string ProgramCode { get; set; }
        [StringLength(10)]
        public string AcademicYear { get; set; }
        
        public DateTime ExamDate { get; set; }
        [StringLength(25)]
        public string ExamSession { get; set; }
        [StringLength(25)]
        public string SubjectCode { get; set; }
        [StringLength(25)]
        public string ExamSlot { get; set; }
        [StringLength(25)]
        public string YearCode { get; set; }
        [StringLength(25)]
        public string SemeseterCode { get; set; }
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; } = DateTime.Now;
    }
}
