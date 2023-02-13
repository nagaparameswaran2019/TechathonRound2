using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityManagementPortalEntity.Model;

namespace UniversityManagementPortalEntity
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        //DbSet<Test> Tests { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<University> University { get; set; }
        DbSet<Document> Document { get; set; }
        DbSet<Registration> Registration { get; set; }
        DbSet<Result> Result { get; set; }
        DbSet<StudentFee> StudentFee { get; set; }
        DbSet<Subject> Subject { get; set; }
        DbSet<CertificationVerification> CertificationVerification { get; set; }
        //DbSet<AddressMaster> AddressMaster { get; set; }
        DbSet<Exam> Exam { get; set; }

        DbSet<LookUp> LookUp { get; set; }
        DbSet<LookUpGroup> LookUpGroups { get; set; }

        DbSet<StaffProfile> StaffProfile { get; set; }
        DbSet<Applicant> Applicant { get; set; }
        DbSet<PortalUser> PortalUser { get; set; }
        DbSet<ApplicationUser> ApplicationUser { get; set; }
        DbSet<ApplicationRole> ApplicationRole { get; set; }
        DbSet<SemesterMaster> SemesterMaster { get; set; }
    }
}