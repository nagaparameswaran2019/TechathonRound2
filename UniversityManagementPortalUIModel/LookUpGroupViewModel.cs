using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementPortal.UIModel
{

    public partial class LookUpGroupViewModel
    {
        public LookUpGroupViewModel() {
            this.LookUps = new List<LookUpViewModel>();
        }
        public int LookUpGroupId { get; set; }
        [StringLength(8)]
        public string Code { get; set; } = null!;
        [StringLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<LookUpViewModel> LookUps { get; set; } 
    }
}