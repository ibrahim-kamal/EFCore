using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class change_post_table_to_My_posts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Post_postId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "My_Posts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_My_Posts",
                table: "My_Posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_My_Posts_postId",
                table: "Photos",
                column: "postId",
                principalTable: "My_Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_My_Posts_postId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_My_Posts",
                table: "My_Posts");

            migrationBuilder.RenameTable(
                name: "My_Posts",
                newName: "Post");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Post_postId",
                table: "Photos",
                column: "postId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
