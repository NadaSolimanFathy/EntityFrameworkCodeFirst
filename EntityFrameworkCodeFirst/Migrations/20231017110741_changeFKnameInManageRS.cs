using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCodeFirst.Migrations
{
    public partial class changeFKnameInManageRS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Departments",
                newName: "managerId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                newName: "IX_Departments_managerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_managerId",
                table: "Departments",
                column: "managerId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_managerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "managerId",
                table: "Departments",
                newName: "InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_managerId",
                table: "Departments",
                newName: "IX_Departments_InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }
    }
}
