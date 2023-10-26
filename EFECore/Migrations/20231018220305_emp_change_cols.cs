using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class emp_change_cols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataType",
                schema: "mySchema",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "agent",
                comment: "admin , Manager, agent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                schema: "mySchema",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "dataType",
                schema: "mySchema",
                table: "Employees",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                comment: "admin , Manager, agent");
        }
    }
}
