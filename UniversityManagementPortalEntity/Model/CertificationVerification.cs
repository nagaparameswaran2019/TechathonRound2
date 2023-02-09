using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class CertificationVerification
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        [StringLength(250)]
        public string DocumentStatus { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual Document Document { get; set; }
    }
}
