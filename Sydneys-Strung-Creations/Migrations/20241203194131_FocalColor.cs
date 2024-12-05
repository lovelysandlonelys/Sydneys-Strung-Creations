using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sydneys_Strung_Creations.Migrations
{
    /// <inheritdoc />
    public partial class FocalColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FocalColor",
                table: "gallary_listing",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FocalColor",
                table: "gallary_listing");
        }
    }
}
