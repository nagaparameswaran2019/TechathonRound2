using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(250)]
        public string AddrLine1 { get; set; }
        [MaxLength(250)]
        public string AddrLine2 { get; set; }
        [MaxLength(250)]
        public string City { get; set; }
        [MaxLength(250)]
        public string State { get; set; }
        [MaxLength(250)]
        public string Country { get; set; }
        public int Zip { get; set; }
    }
}
