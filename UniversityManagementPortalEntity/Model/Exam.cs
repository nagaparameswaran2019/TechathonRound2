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
        public int DepartmentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
