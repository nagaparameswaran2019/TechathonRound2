using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }
        public bool IsActive { get; set; }

    }
}
