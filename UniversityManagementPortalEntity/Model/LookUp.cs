using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementPortalEntity.Model
{
    public partial class LookUp
    {
        public int LookUpId { get; set; }

        [StringLength(8)]
        public string Code { get; set; } = null!;

        [StringLength(500)]
        public string? Description { get; set; }

        public int LookUpGroupId { get; set; }
        public virtual LookUpGroup LookUpGroup { get; set; } = null!;
    } 
}