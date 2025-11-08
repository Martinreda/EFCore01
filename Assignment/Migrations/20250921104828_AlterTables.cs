using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AlterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_courses_CourseId",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_students_StudentId",
                table: "stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stud_Courses",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_CourseId",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_StudentId",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "DepId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "inst_Id",
                table: "departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stud_Courses",
                table: "stud_Courses",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_Course_Id",
                table: "stud_Courses",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_courses_Course_Id",
                table: "stud_Courses",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_students_Stud_Id",
                table: "stud_Courses",
                column: "Stud_Id",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_courses_Course_Id",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_students_Stud_Id",
                table: "stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stud_Courses",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_Course_Id",
                table: "stud_Courses");

            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "stud_Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "stud_Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "inst_Id",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_stud_Courses",
                table: "stud_Courses",
                columns: new[] { "Course_Id", "Stud_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_CourseId",
                table: "stud_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_StudentId",
                table: "stud_Courses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_courses_CourseId",
                table: "stud_Courses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_students_StudentId",
                table: "stud_Courses",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id");
        }
    }
}
