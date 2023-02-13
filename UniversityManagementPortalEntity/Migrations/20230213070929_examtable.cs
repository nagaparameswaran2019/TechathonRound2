using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagementPortalEntity.Migrations
{
    public partial class examtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "DepartmentType",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Exam",
                newName: "ExamDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Exam",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Exam",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AcademicYear",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamSession",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamSlot",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProgramCode",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SemeseterCode",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YearCode",
                table: "Exam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicYear",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "ExamSession",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "ExamSlot",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "ProgramCode",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "SemeseterCode",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "SubjectCode",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "YearCode",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "ExamDate",
                table: "Exam",
                newName: "StartDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentType",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Exam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EndTime",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartTime",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
