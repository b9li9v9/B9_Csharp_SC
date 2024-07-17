using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Depts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptHeadId = table.Column<long>(type: "bigint", nullable: false),
                    OrgId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Depts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Emps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    DeptId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Emps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Orgs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgHeadId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Orgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acct = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    pwd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    pwdddd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Users", x => x.Id);
                });
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
