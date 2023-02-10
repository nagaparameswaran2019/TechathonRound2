using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class StaffTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo1 = table.Column<int>(type: "int", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddrLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddrLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffProfile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffProfile");
        }
    }
}
