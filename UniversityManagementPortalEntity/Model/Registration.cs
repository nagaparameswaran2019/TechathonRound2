using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Students")]
        public int StudentId { get; set; }

        [ForeignKey("Document")]
        public int DepartmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public int CourseType { get; set; }
        [StringLength(20)]
        public string CoreDocumentStatus { get; set; }

    }
}
