using Microsoft.EntityFrameworkCore.Migrations;

namespace Emr.Web.Migrations
{
    public partial class IDK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_HealthGroup_HealthGroupGuid",
                table: "PatientRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthGroup",
                table: "HealthGroup");

            migrationBuilder.RenameTable(
                name: "HealthGroup",
                newName: "HealthGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthGroups",
                table: "HealthGroups",
                column: "HealthGroupGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_HealthGroups_HealthGroupGuid",
                table: "PatientRecords",
                column: "HealthGroupGuid",
                principalTable: "HealthGroups",
                principalColumn: "HealthGroupGuid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecords_HealthGroups_HealthGroupGuid",
                table: "PatientRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthGroups",
                table: "HealthGroups");

            migrationBuilder.RenameTable(
                name: "HealthGroups",
                newName: "HealthGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthGroup",
                table: "HealthGroup",
                column: "HealthGroupGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecords_HealthGroup_HealthGroupGuid",
                table: "PatientRecords",
                column: "HealthGroupGuid",
                principalTable: "HealthGroup",
                principalColumn: "HealthGroupGuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
