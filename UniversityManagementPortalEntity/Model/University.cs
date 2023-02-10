using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Website { get; set; }
        public int ContactNo1 { get; set; }
        public int ContactNo2 { get; set; }
        [StringLength(250)]
        public string EmailID { get; set; }
        [StringLength(250)]
        public string ChairmanName { get; set; }
        [StringLength(250)]
        public string DeanName { get; set; }

        [ForeignKey("AspNetUsers")]
        [StringLength(900)]
        public string AspNetUsersId { get; set; }

        //[ForeignKey("Address")]
        public int AddressId { get; set; }
        //public virtual IdentityUser ApplicationUser { get; set; }
        //public virtual AddressMaster Address { get; set; }

    }
}
