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
                name: "T_Depts",
                columns: table => new
                {
                    DeptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOwn = table.Column<long>(type: "bigint", nullable: false),
                    OrgOwn = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Depts", x => x.DeptId);
                    table.ForeignKey(
                        name: "FK_T_Depts_T_Users_UserOwn",
                        column: x => x.UserOwn,
                        principalTable: "T_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Emps",
                columns: table => new
                {
                    EmpId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOwn = table.Column<long>(type: "bigint", nullable: false),
                    DeptOwn = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Emps", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_T_Emps_T_Users_UserOwn",
                        column: x => x.UserOwn,
                        principalTable: "T_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Orgs",
                columns: table => new
                {
                    OrgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOwn = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Orgs", x => x.OrgId);
                    table.ForeignKey(
                        name: "FK_T_Orgs_T_Users_UserOwn",
                        column: x => x.UserOwn,
                        principalTable: "T_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Depts_UserOwn",
                table: "T_Depts",
                column: "UserOwn");

            migrationBuilder.CreateIndex(
                name: "IX_T_Emps_UserOwn",
                table: "T_Emps",
                column: "UserOwn");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orgs_UserOwn",
                table: "T_Orgs",
                column: "UserOwn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Depts");

            migrationBuilder.DropTable(
                name: "T_Emps");

            migrationBuilder.DropTable(
                name: "T_Orgs");

            migrationBuilder.DropTable(
                name: "T_Users");
        }
    }
}
