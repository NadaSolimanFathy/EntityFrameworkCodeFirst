using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCodeFirst.Migrations
{
    public partial class MakeIndIdInDeptTableOPtional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_managerId",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "managerId",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_managerId",
                table: "Departments",
                column: "managerId",
                unique: true,
                filter: "[managerId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_managerId",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "managerId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_managerId",
                table: "Departments",
                column: "managerId",
                unique: true);
        }
    }
}
