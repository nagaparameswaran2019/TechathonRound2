using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class aplicanttableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "Applicant",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CGPA",
                table: "Applicant",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HSCMark",
                table: "Applicant",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SSLCMark",
                table: "Applicant",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batch",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "CGPA",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "HSCMark",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "SSLCMark",
                table: "Applicant");
        }
    }
}
