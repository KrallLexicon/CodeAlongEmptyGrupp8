using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAlongEmpty.Migrations
{
    public partial class AddedcartableandphonenumbertoPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "People",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegNumber = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    CarModel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "People");
        }
    }
}
