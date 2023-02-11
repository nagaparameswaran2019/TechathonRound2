using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementPortal.UIModel
{

    public partial class LookUpGroup
    {
        public int LookUpGroupId { get; set; }
        [StringLength(8)]
        public string Code { get; set; } = null!;
        [StringLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<LookUp> LookUps { get; } = new List<LookUp>();
    }
}