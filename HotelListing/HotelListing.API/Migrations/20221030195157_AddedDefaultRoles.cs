using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56715da2-7691-4bef-b4cc-c093bb2d2ab7", "9bb8e6e8-cd15-440b-befb-ddf92b528bcc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa187ad8-4bcb-4721-b2d7-2e3e0fae7953", "14f0daa1-aade-4031-b529-7d791b37c210", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56715da2-7691-4bef-b4cc-c093bb2d2ab7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa187ad8-4bcb-4721-b2d7-2e3e0fae7953");
        }
    }
}
