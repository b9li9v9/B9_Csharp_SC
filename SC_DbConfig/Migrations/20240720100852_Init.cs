using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pwd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "T_OrgUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NodeLeader = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OrgUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_OrgUnits_T_OrgUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "T_OrgUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_OrgUnits_T_Users_NodeLeader",
                        column: x => x.NodeLeader,
                        principalTable: "T_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_OrgUnits_NodeLeader",
                table: "T_OrgUnits",
                column: "NodeLeader");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrgUnits_ParentId",
                table: "T_OrgUnits",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_OrgUnits");

            migrationBuilder.DropTable(
                name: "T_Users");
        }
    }
}
