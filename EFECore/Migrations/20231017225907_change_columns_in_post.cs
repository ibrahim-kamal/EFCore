using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class change_columns_in_post : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "postId",
                schema: "mySchema",
                table: "Photos",
                type: "BigInt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "mySchema",
                table: "My_Posts",
                type: "BigInt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "postId",
                schema: "testSchema",
                table: "CatImages",
                type: "BigInt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "postId",
                schema: "mySchema",
                table: "Photos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BigInt");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "mySchema",
                table: "My_Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BigInt")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "postId",
                schema: "testSchema",
                table: "CatImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BigInt");
        }
    }
}
