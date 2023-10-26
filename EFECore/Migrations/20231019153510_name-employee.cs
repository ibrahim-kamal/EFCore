using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class nameemployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "firstname",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[firstname] + ' ' + [lastname] ",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstname",
                schema: "mySchema",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "lastname",
                schema: "mySchema",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[firstname] + ' ' + [lastname] ");
        }
    }
}
