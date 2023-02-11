using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementPortal.UIModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name", Prompt = "Enter first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name", Prompt = "Enter last name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name", Prompt = "Enter middle name")]
        public string MiddleName { get; set; }
        [Display(Name = "Date of birth", Prompt = "Enter data of birth")]
        public DateTime Dob { get; set; }
        [Display(Name = "Email", Prompt = "Enter email")]
        public string EmailId { get; set; }

        [Display(Name = "Contact No", Prompt = "Enter contact no")]
        public int ContactNo1 { get; set; }

        [Display(Name = "Alternate Contact no", Prompt = "Enter alternate contact no")]
        public int AltContactNo2 { get; set; }

        [Display(Name = "Acadamic Start date", Prompt = "Acadamic Start date")]
        public DateTime? AcadamicStartDate { get; set; }

        [Display(Name = "Acadamic End date", Prompt = "Acadamic End date")]
        public DateTime? AcadamicEndDate { get; set; }

        [Display(Name = "Gender", Prompt = "Select gender")]
        public string Sex { get; set; }

        [Display(Name = "Father's Name", Prompt = "Enter father's name")]
        public string? FatherName { get; set; }

        [Display(Name = "Mother's Name", Prompt = "Enter mother's name")]
        public string? MotherName { get; set; }

        [Display(Name = "Adhar No", Prompt = "Enter adhar no")]
        public string AdharNo { get; set; }
        public string? Photo { get; set; }

        [Display(Name = "Blood Group", Prompt = "Enter blood group")]
        public string? BloodGroup { get; set; }
        public string? AspNetUsersId { get; set; }
        public int? AddressId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}