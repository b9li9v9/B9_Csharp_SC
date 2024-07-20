using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrgUnits_T_Users_NodeLeader",
                table: "T_OrgUnits");

            migrationBuilder.RenameColumn(
                name: "NodeLeader",
                table: "T_OrgUnits",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "T_OrgUnits",
                newName: "OrgName");

            migrationBuilder.RenameIndex(
                name: "IX_T_OrgUnits_NodeLeader",
                table: "T_OrgUnits",
                newName: "IX_T_OrgUnits_UserId");

            migrationBuilder.AddColumn<bool>(
                name: "AV",
                table: "T_OrgUnits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EmpName",
                table: "T_OrgUnits",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrgUnits_T_Users_UserId",
                table: "T_OrgUnits",
                column: "UserId",
                principalTable: "T_Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrgUnits_T_Users_UserId",
                table: "T_OrgUnits");

            migrationBuilder.DropColumn(
                name: "AV",
                table: "T_OrgUnits");

            migrationBuilder.DropColumn(
                name: "EmpName",
                table: "T_OrgUnits");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "T_OrgUnits",
                newName: "NodeLeader");

            migrationBuilder.RenameColumn(
                name: "OrgName",
                table: "T_OrgUnits",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_T_OrgUnits_UserId",
                table: "T_OrgUnits",
                newName: "IX_T_OrgUnits_NodeLeader");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrgUnits_T_Users_NodeLeader",
                table: "T_OrgUnits",
                column: "NodeLeader",
                principalTable: "T_Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
