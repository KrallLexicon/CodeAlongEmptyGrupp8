using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAlongEmpty.Migrations
{
    public partial class Seededrolesandaddeddefaultadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4eaf9e72-18b4-4e15-9ae7-556dd48134ac", "c488afaa-9f16-4c42-bafd-2de60d26c1d6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7b7b38b-fa89-4f82-86ac-017725f00667", "096ae26c-7ecd-4381-826f-d6f1440aaffa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c40977b8-ac1c-4272-b2e4-8dce2d734593", 0, 9001, "Admintown", "89853c95-953e-4f3b-9734-cb8ee0c6ca17", "admin@admin.com", false, false, null, "Admin Adminsson", "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDceLgaBkUt1SF5tHUmTlSaywPR+sFEo5wieln8A/LCr8dpUtVde5nswPk/3mN0PnA==", null, false, "aae77722-f367-4b9c-b187-6d244e3bf102", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c40977b8-ac1c-4272-b2e4-8dce2d734593", "4eaf9e72-18b4-4e15-9ae7-556dd48134ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b7b38b-fa89-4f82-86ac-017725f00667");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c40977b8-ac1c-4272-b2e4-8dce2d734593", "4eaf9e72-18b4-4e15-9ae7-556dd48134ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eaf9e72-18b4-4e15-9ae7-556dd48134ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c40977b8-ac1c-4272-b2e4-8dce2d734593");
        }
    }
}
