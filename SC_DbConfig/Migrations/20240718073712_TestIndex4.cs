using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class TestIndex4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orgs_OrgName_OrgHeadId",
                table: "T_Orgs",
                columns: new[] { "OrgName", "OrgHeadId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_Orgs_OrgName_OrgHeadId",
                table: "T_Orgs");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs",
                column: "OrgName");
        }
    }
}
