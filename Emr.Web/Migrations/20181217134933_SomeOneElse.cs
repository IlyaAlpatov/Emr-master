using Microsoft.EntityFrameworkCore.Migrations;

namespace Emr.Web.Migrations
{
    public partial class SomeOneElse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RoleId",
                table: "Clients",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoleId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Clients");
        }
    }
}
