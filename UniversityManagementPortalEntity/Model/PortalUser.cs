using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortalEntity.Model
{
    public class PortalUser
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string DisplayName { get; set; }
        [StringLength(250)]
        public string? FirstName { get; set; }
        [StringLength(250)]
        public string? LastName { get; set; }
        [StringLength(10)]
        public string? RoleId { get; set; }
        [StringLength(250)]
        public string WebSite { get; set; }
        
        public int? ContactNo1 { get; set; }
        [StringLength(250)]
        public string? AddrLine1 { get; set; }
        [StringLength(250)]
        public string? AddrLine2 { get; set; }
        [StringLength(10)]
        public int? ZipCode { get; set; }
        [StringLength(250)]
        public string? City { get; set; }
        [StringLength(250)]
        public string? State { get; set; }
        [StringLength(250)]
        public string? Country { get; set; }
        [StringLength(250)]
        public string AspNetUserId { get; set; }
    }
}
