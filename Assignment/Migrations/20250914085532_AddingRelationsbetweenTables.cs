using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationsbetweenTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                table: "courses");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "students",
                type: "int",
                nullable: true);

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
                name: "DepartmentId",
                table: "instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mangerId",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "course_Insts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "course_Insts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_DepartmentId",
                table: "students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_CourseId",
                table: "stud_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_StudentId",
                table: "stud_Courses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_mangerId",
                table: "departments",
                column: "mangerId",
                unique: true,
                filter: "[mangerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_courses_TopicID",
                table: "courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_CourseId",
                table: "course_Insts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_InstructorId",
                table: "course_Insts",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Insts_courses_CourseId",
                table: "course_Insts",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Insts_instructors_InstructorId",
                table: "course_Insts",
                column: "InstructorId",
                principalTable: "instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_topics_TopicID",
                table: "courses",
                column: "TopicID",
                principalTable: "topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_instructors_mangerId",
                table: "departments",
                column: "mangerId",
                principalTable: "instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DepartmentId",
                table: "instructors",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DepartmentId",
                table: "students",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Insts_courses_CourseId",
                table: "course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_course_Insts_instructors_InstructorId",
                table: "course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_topics_TopicID",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_instructors_mangerId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DepartmentId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_courses_CourseId",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_students_StudentId",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DepartmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_DepartmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_CourseId",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_StudentId",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_departments_mangerId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_courses_TopicID",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_course_Insts_CourseId",
                table: "course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_course_Insts_InstructorId",
                table: "course_Insts");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "mangerId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "course_Insts");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "course_Insts");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
