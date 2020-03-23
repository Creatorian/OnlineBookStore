using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookstore.Data.Migrations
{
    public partial class AuthorsandCategoriesViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldItems",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldItems",
                table: "Books");
        }
    }
}
