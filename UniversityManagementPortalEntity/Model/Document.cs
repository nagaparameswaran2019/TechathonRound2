using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversityManagementPortalEntity.Model
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }

        public int DocumentType { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        [StringLength(250)]
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
