using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class usertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortalUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ContactNo1 = table.Column<int>(type: "int", nullable: false),
                    AddrLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddrLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ZipCode = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    State = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AspNetUserId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalUser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortalUser");
        }
    }
}
