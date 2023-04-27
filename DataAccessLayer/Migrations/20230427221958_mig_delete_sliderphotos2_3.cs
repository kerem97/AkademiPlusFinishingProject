using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_delete_sliderphotos2_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl2",
                table: "SliderPhotos");

            migrationBuilder.DropColumn(
                name: "PhotoUrl3",
                table: "SliderPhotos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl2",
                table: "SliderPhotos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl3",
                table: "SliderPhotos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
