using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortal.UIModel
{
    public class PortalUserViewModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RoleId { get; set; }
        public string WebSite { get; set; }
        public int? ContactNo1 { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public int? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string AspNetUserId { get; set; }
    }
}
