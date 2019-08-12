using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_FrameworkProject.Migrations
{
    public partial class fixedSchedulewithvirtualforStudentandCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "Schedules");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CourseId",
                table: "Schedules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StudentId",
                table: "Schedules",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Courses_CourseId",
                table: "Schedules",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Students_StudentId",
                table: "Schedules",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Courses_CourseId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Students_StudentId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_CourseId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_StudentId",
                table: "Schedules");

            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);
        }
    }
}
