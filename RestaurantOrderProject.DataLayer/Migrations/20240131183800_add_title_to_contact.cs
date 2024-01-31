using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantOrderProject.DataAccessLayer.Migrations
{
    public partial class add_title_to_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactTitle",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactTitle",
                table: "Contacts");
        }
    }
}
