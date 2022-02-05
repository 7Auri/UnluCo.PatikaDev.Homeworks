using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_patika_dev.Migrations
{
    public partial class PatikaDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "EducationPartipant");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Successz");

            migrationBuilder.DropTable(
                name: "Partipants");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Educations");
        }
    }
}
