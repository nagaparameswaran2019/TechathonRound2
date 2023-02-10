namespace UniversityManagementPortal.UIModel
{
    public class StudentViewModel
    {
        
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Dob { get; set; }
        public string EmailId { get; set; }
        public int ContactNo1 { get; set; }
        public int AltContactNo2 { get; set; }
        public DateTime AcadamicStartDate { get; set; }
        public DateTime AcadamicEndDate { get; set; }
        public int Sex { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string AdharNo { get; set; }
        public string Photo { get; set; }
        public string BloodGroup { get; set; }
        public string AspNetUsersId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int CreatedBy { get; set; }  
    }
}