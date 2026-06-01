using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMatch.Migrations
{
    /// <inheritdoc />
    public partial class AddProductUrlToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductUrl",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductUrl",
                table: "Applications");
        }
    }
}
