using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversityManagementPortal.UIModel
{
    public class ExamSchduler
    {
        [Display(Name = "Program")]
        public string ProgramCode { get; set; }
        [Display(Name = "Year")]
        public ICollection<LookUpViewModel>? ProgramYear { get; set; }

        [Display(Name = "Academic Year")]
        public string AcademicYear { get; set; }
        [Display(Name = "Semester")]
        public string Semester { get; set; }
        public ICollection<LookUpViewModel>?  ProgramList { get; set; }
        public ICollection<LookUpViewModel>? Semesters { get; set; }
    }
}
