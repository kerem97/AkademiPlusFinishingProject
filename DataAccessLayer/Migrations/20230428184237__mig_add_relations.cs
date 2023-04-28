using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _mig_add_relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserID",
                table: "Comment",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AppUserID",
                table: "Blogs",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserID",
                table: "Blogs",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserID",
                table: "Comment",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AppUserID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AppUserID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Blogs");
        }
    }
}
