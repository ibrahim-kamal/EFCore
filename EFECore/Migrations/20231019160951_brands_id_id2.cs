using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class brands_id_id2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                schema: "mySchema",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subCategory",
                schema: "mySchema",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategory", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "brands",
                schema: "mySchema");

            migrationBuilder.DropTable(
                name: "subCategory",
                schema: "mySchema");
        }
    }
}
