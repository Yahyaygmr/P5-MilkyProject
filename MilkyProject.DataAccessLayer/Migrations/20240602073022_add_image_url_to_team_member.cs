using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkyProject.DataAccessLayer.Migrations
{
    public partial class add_image_url_to_team_member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TeamMembers");
        }
    }
}
