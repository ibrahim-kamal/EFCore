using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFECore.Migrations
{
    /// <inheritdoc />
    public partial class getDateForPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "datetime",
                schema: "mySchema",
                table: "My_Posts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datetime",
                schema: "mySchema",
                table: "My_Posts");
        }
    }
}
