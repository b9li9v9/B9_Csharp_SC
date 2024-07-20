using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrgUnits_T_OrgUnits_ParentId",
                table: "T_OrgUnits");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "T_OrgUnits",
                newName: "ParentGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "T_OrgUnits",
                newName: "Guid");

            migrationBuilder.RenameIndex(
                name: "IX_T_OrgUnits_ParentId",
                table: "T_OrgUnits",
                newName: "IX_T_OrgUnits_ParentGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrgUnits_T_OrgUnits_ParentGuid",
                table: "T_OrgUnits",
                column: "ParentGuid",
                principalTable: "T_OrgUnits",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrgUnits_T_OrgUnits_ParentGuid",
                table: "T_OrgUnits");

            migrationBuilder.RenameColumn(
                name: "ParentGuid",
                table: "T_OrgUnits",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "T_OrgUnits",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_T_OrgUnits_ParentGuid",
                table: "T_OrgUnits",
                newName: "IX_T_OrgUnits_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrgUnits_T_OrgUnits_ParentId",
                table: "T_OrgUnits",
                column: "ParentId",
                principalTable: "T_OrgUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
