using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherViewer.WebApiWebApi.Migrations
{
    /// <inheritdoc />
    public partial class GetCitiesByCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "WeatherData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "WeatherData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId1",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeatherData_CityId",
                table: "WeatherData",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherData_CountryId",
                table: "WeatherData",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId1",
                table: "City",
                column: "CountryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId1",
                table: "City",
                column: "CountryId1",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_City_CityId",
                table: "WeatherData",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherData_Country_CountryId",
                table: "WeatherData",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId1",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_City_CityId",
                table: "WeatherData");

            migrationBuilder.DropForeignKey(
                name: "FK_WeatherData_Country_CountryId",
                table: "WeatherData");

            migrationBuilder.DropIndex(
                name: "IX_WeatherData_CityId",
                table: "WeatherData");

            migrationBuilder.DropIndex(
                name: "IX_WeatherData_CountryId",
                table: "WeatherData");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryId1",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "WeatherData");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "WeatherData");

            migrationBuilder.DropColumn(
                name: "CountryId1",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
