using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class aplicantupdate111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltContactNo2",
                table: "Applicant");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo1",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo2",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo2",
                table: "Applicant");

            migrationBuilder.AlterColumn<int>(
                name: "ContactNo1",
                table: "Applicant",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AltContactNo2",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
