using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Depts_T_Users_UserOwn",
                table: "T_Depts");

            migrationBuilder.AlterColumn<long>(
                name: "UserOwn",
                table: "T_Depts",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Depts_T_Users_UserOwn",
                table: "T_Depts",
                column: "UserOwn",
                principalTable: "T_Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Depts_T_Users_UserOwn",
                table: "T_Depts");

            migrationBuilder.AlterColumn<long>(
                name: "UserOwn",
                table: "T_Depts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Depts_T_Users_UserOwn",
                table: "T_Depts",
                column: "UserOwn",
                principalTable: "T_Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
