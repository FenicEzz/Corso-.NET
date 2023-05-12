using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddProvince : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "Cities");
        }
    }
}
