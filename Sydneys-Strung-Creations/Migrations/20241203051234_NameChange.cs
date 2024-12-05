using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sydneys_Strung_Creations.Migrations
{
    /// <inheritdoc />
    public partial class NameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JewleryTemplateURL",
                table: "jewlery_template",
                newName: "JewleryTemplatePath");

            migrationBuilder.RenameColumn(
                name: "JewleryPictureURL",
                table: "gallary_listing",
                newName: "JewleryPicturePath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JewleryTemplatePath",
                table: "jewlery_template",
                newName: "JewleryTemplateURL");

            migrationBuilder.RenameColumn(
                name: "JewleryPicturePath",
                table: "gallary_listing",
                newName: "JewleryPictureURL");
        }
    }
}
