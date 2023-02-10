using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementPortalEntity.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string MiddleName { get; set; }
        public DateTime Dob { get; set; }
        [StringLength(500)]
        public string EmailId { get; set; }
        public int ContactNo1 { get; set; }
        public int AltContactNo2 { get; set; }
        public DateTime AcadamicStartDate { get; set; }
        public DateTime AcadamicEndDate { get; set; }
        public int Sex { get; set; }
        [StringLength(250)]
        public string FatherName { get; set; }
        [StringLength(250)]
        public string MotherName { get; set; }
        [StringLength(20)]
        public string AdharNo { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [StringLength(20)]
        public string BloodGroup { get; set; }

        [ForeignKey("AspNetUsers")]
        [StringLength(900)]
        public string AspNetUsersId { get; set; }

        //[ForeignKey("Address")]
        public int AddressId { get; set; }
        //public virtual IdentityUser ApplicationUser { get; set; }
        //public virtual AddressMaster Address { get; set; }
        public int CreatedBy { get; set; }

        private DateTime? _createdOn = null;
        public DateTime CreatedOn
        {
            get
            {
                return this._createdOn.HasValue
                   ? this._createdOn.Value
                   : DateTime.Now;
            }
            set { this._createdOn = value; }
        }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
