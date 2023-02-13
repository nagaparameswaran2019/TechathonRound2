using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class SemesterMaster
    {
        public int Id { get; set; }
        public string SemeseterCode { get; set; }
        public string SubjectCode { get; set; }
        public string YearCode { get; set; }
        public string ProgramCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
