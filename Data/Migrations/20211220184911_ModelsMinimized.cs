using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class ModelsMinimized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserStatisticDetails_AspNetUsers_Id",
                table: "UserStatisticDetails");

            migrationBuilder.DropTable(
                name: "CampaignDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserStatisticDetails_Id",
                table: "UserStatisticDetails");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalRentTime",
                table: "UserStatisticDetails");

            migrationBuilder.DropColumn(
                name: "YearOfRegister",
                table: "UserStatisticDetails");

            migrationBuilder.DropColumn(
                name: "CarDoors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarSeats",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserStatisticDetails",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RentDate",
                table: "Reservations",
                newName: "ReservationDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRegister",
                table: "UserStatisticDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_UserStatisticDetails_UserId",
                table: "UserStatisticDetails",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserStatisticDetails_AspNetUsers_UserId",
                table: "UserStatisticDetails",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserStatisticDetails_AspNetUsers_UserId",
                table: "UserStatisticDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserStatisticDetails_UserId",
                table: "UserStatisticDetails");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfRegister",
                table: "UserStatisticDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserStatisticDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReservationDate",
                table: "Reservations",
                newName: "RentDate");

            migrationBuilder.AddColumn<int>(
                name: "TotalRentTime",
                table: "UserStatisticDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearOfRegister",
                table: "UserStatisticDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "CampaignDetails",
                columns: table => new
                {
                    CampaignDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignDiscount = table.Column<double>(type: "float", nullable: false),
                    CampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumberOfCampaigns = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignDetails", x => x.CampaignDetailsId);
                    table.ForeignKey(
                        name: "FK_CampaignDetails_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserStatisticDetails_Id",
                table: "UserStatisticDetails",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                unique: true,
                filter: "[AddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignDetails_Id",
                table: "CampaignDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserStatisticDetails_AspNetUsers_Id",
                table: "UserStatisticDetails",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
