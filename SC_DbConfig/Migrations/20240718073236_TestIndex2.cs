using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class TestIndex2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs",
                column: "OrgName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orgs_OrgName",
                table: "T_Orgs",
                column: "OrgName");
        }
    }
}
