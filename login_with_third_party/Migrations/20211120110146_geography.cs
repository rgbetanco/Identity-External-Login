using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace login_with_third_party.Migrations
{
    public partial class geography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationX",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationY",
                table: "Locations");

            migrationBuilder.AddColumn<Point>(
                name: "LocationPoint",
                table: "Locations",
                type: "geography",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationPoint",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "LocationX",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationY",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
