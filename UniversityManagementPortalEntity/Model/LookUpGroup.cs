using System;
using System.Collections.Generic;

namespace UniversityManagementPortalEntity.Model
{

    public partial class LookUpGroup
    {
        public int LookUpGroupId { get; set; }

        public string Code { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<LookUp> LookUps { get; } = new List<LookUp>();
    }
}