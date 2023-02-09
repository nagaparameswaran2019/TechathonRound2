using System;
using System.Collections.Generic;

namespace UniversityManagementPortalEntity.Model
{
    public partial class LookUp
    {
        public int LookUpId { get; set; }

        public string Code { get; set; } = null!;

        public string? Description { get; set; }

        public int LookUpGroupId { get; set; } 
    } 
}