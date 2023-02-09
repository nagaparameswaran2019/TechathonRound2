﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        DbSet<Address> Address { get; set; }
        DbSet<Exam> Exam { get; set; }
    }
}