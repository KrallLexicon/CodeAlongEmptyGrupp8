using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAlongEmpty.Migrations
{
    public partial class AddedCarOwnerassociationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarOwners",
                columns: table => new
                {
                    RegNumber = table.Column<string>(nullable: false),
                    SSN = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwners", x => new { x.RegNumber, x.SSN });
                    table.ForeignKey(
                        name: "FK_CarOwners_Cars_RegNumber",
                        column: x => x.RegNumber,
                        principalTable: "Cars",
                        principalColumn: "RegNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOwners_People_SSN",
                        column: x => x.SSN,
                        principalTable: "People",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOwners_SSN",
                table: "CarOwners",
                column: "SSN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarOwners");
        }
    }
}
