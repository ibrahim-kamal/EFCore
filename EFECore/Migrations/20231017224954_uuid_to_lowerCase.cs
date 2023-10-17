using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class uuid_to_lowerCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "mySchema");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Student",
                newSchema: "mySchema");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photos",
                newSchema: "mySchema");

            migrationBuilder.RenameTable(
                name: "My_Posts",
                newName: "My_Posts",
                newSchema: "mySchema");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "mySchema");

            migrationBuilder.RenameColumn(
                name: "UUID",
                schema: "mySchema",
                table: "Student",
                newName: "uuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Student",
                schema: "mySchema",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Photos",
                schema: "mySchema",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "My_Posts",
                schema: "mySchema",
                newName: "My_Posts");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "mySchema",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "uuid",
                table: "Student",
                newName: "UUID");
        }
    }
}
