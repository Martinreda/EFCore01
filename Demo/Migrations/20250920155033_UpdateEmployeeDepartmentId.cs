using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeDepartmentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Employees",
                newName: "DeparmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DeptId",
                table: "Employees",
                newName: "IX_Employees_DeparmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeparmentId",
                table: "Employees",
                column: "DeparmentId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeparmentId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DeparmentId",
                table: "Employees",
                newName: "DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DeparmentId",
                table: "Employees",
                newName: "IX_Employees_DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptId",
                table: "Employees",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
