using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class CarModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarGearboxType",
                table: "Cars",
                newName: "CarTransmissionType");

            migrationBuilder.AddColumn<int>(
                name: "CarDoors",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarSeats",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarDoors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarSeats",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarTransmissionType",
                table: "Cars",
                newName: "CarGearboxType");
        }
    }
}
