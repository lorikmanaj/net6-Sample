using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class SeededCountriesHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "ShortName" },
                values: new object[] { 1, "Kosovo", "XK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "ShortName" },
                values: new object[] { 2, "United Kingdom", "UK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "ShortName" },
                values: new object[] { 3, "Germany", "GR" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "H1 Add", 1, "Hotel 1", 4.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "H2 Add", 2, "Hotel 2", 3.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 3, "H3 Add", 3, "Hotel 3", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);
        }
    }
}
