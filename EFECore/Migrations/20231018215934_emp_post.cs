using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class emp_post : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employeesPosts",
                schema: "mySchema",
                columns: table => new
                {
                    employeesPost = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_emp_post_id", x => x.employeesPost);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeesPosts",
                schema: "mySchema");
        }
    }
}
