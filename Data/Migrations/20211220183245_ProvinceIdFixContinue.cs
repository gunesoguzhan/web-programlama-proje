using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class ProvinceIdFixContinue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Provinces");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Provinces",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
