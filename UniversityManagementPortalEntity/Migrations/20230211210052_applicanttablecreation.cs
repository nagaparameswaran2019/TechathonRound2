using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class applicanttablecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ContactNo1 = table.Column<int>(type: "int", nullable: false),
                    AltContactNo2 = table.Column<int>(type: "int", nullable: false),
                    AcadamicStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcadamicEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AdharNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    AspNetUsersId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    State = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");
        }
    }
}
