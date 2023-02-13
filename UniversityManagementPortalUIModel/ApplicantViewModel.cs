using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UniversityManagementPortal.UIModel
{
    public class ApplicantViewModel
    {
        public ApplicantViewModel()
        {
            this.GraduationType = new List<SelectListItem>() {
                new SelectListItem(){ Value="POST", Text="Post Graduate"},
                new SelectListItem(){ Value="UNDER", Text="Under Graduate"}
            };
            
        }
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
        public string ContactNo1 { get; set; }

        [Display(Name = "Alternate Contact no", Prompt = "Enter alternate contact no")]
        public string  ContactNo2 { get; set; }

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

        [Display(Name = "Blood Group", Prompt = "Enter blood group")]
        public string? BloodGroup { get; set; }
        public string? AspNetUsersId { get; set; }
        [Display(Name = "Address Line1", Prompt = "Address Line1")]
        public string? AddressLine1 { get; set; }
        [Display(Name = "Address Line2", Prompt = "Address Line2")]
        public string? AddressLine2 { get; set; }
        [Display(Name = "City", Prompt = "City")]
        public string? City { get; set; }
        [Display(Name = "State", Prompt = "State")]
        public string? State { get; set; }
        [Display(Name = "Country", Prompt = "Country")]
        public string? Country { get; set; }
        [Display(Name = "ZipCode", Prompt = "ZipCode")]
        public string? ZipCode { get; set; }

        [Display(Name = "Program")]
        public string ProgramCode { get; set; }

        [Display(Name = "Graduation")]
        public string GraduationCode { get; set; }
        
        [Display(Name = "University")]
        public string UniversityCode { get; set; }

        [Display(Name = "Year Studied")]
        public string? Batch { get; set; }
        public int? CGPA { get; set; }
        public int? SSLCMark { get; set; }
        public int? HSCMark { get; set; }
        public List<LookUpViewModel>? UniversityList { get; set; }
        public List<SelectListItem>? GraduationType { get; set; }
        public ICollection<LookUpViewModel>? UGProgramList { get; set; }
        public List<LookUpViewModel>? PGProgramList { get; set; }
    }
}
