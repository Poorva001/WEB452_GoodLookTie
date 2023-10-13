using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodLookTie.Data.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Occassion",
                table: "Tie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Occassion",
                table: "Tie");
        }
    }
}
