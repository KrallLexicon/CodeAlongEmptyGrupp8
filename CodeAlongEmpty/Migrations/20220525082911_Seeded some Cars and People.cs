using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAlongEmpty.Migrations
{
    public partial class SeededsomeCarsandPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegNumber", "Brand", "CarModel" },
                values: new object[,]
                {
                    { "ABC-123", "Volvo", "V70" },
                    { "DEF-456", "SAAB", "93" },
                    { "GHI-789", "BMW", "E93" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name" },
                values: new object[,]
                {
                    { "880216", "Jonathan Krall" },
                    { "123156", "Sven Svensson" },
                    { "423434", "Anna Andersson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "ABC-123");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "DEF-456");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegNumber",
                keyValue: "GHI-789");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "123156");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "423434");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "880216");
        }
    }
}
