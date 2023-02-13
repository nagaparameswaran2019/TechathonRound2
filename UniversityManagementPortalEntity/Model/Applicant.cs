using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversityManagementPortalEntity.Model
{
    public class Applicant
    {

        public int Id { get; set; }
        [MaxLength(250)]
        public string FirstName { get; set; }
        [MaxLength(250)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string MiddleName { get; set; }
        public DateTime Dob { get; set; }
        [MaxLength(250)]
        public string EmailId { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public DateTime? AcadamicStartDate { get; set; }
        public DateTime? AcadamicEndDate { get; set; }
        [MaxLength(20)]
        public string Sex { get; set; }
        [MaxLength(250)]
        public string? FatherName { get; set; }
        [MaxLength(250)]
        public string? MotherName { get; set; }
        [MaxLength(14)]
        public string AdharNo { get; set; }
        [MaxLength(14)]
        public string? BloodGroup { get; set; }
        [MaxLength(200)]
        public string? AspNetUsersId { get; set; }
        [MaxLength(250)]
        public string? AddressLine1 { get; set; }
        [MaxLength(250)]
        public string? AddressLine2 { get; set; }
        [MaxLength(250)]
        public string? City { get; set; }
        [MaxLength(250)]
        public string? State { get; set; }
        [MaxLength(250)]
        public string? Country { get; set; }
        [MaxLength(6)]
        public string? ZipCode { get; set; }
        [StringLength(10)]
        public string ProgramCode { get; set; }
        [StringLength(10)]
        public string GraduationCode { get; set; }
        [StringLength(200)]
        public string UniversityCode { get; set; }
        [StringLength(100)]
        public string? Batch { get; set; }
        public int? CGPA { get; set; }
        public int? SSLCMark { get; set; }
        public int? HSCMark { get; set; }
    }
}
