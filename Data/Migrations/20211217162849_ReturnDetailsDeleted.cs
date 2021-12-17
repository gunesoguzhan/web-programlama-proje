using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class ReturnDetailsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentDetails_AspNetUsers_Id",
                table: "RentDetails");

            migrationBuilder.DropTable(
                name: "ReturnDetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RentDetails",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RentDetails_Id",
                table: "RentDetails",
                newName: "IX_RentDetails_UserId");

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "RentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "RentDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_RentDetails_AspNetUsers_UserId",
                table: "RentDetails",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentDetails_AspNetUsers_UserId",
                table: "RentDetails");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "RentDetails");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "RentDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RentDetails",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_RentDetails_UserId",
                table: "RentDetails",
                newName: "IX_RentDetails_Id");

            migrationBuilder.CreateTable(
                name: "ReturnDetails",
                columns: table => new
                {
                    ReturnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    RentId = table.Column<int>(type: "int", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnDetails", x => x.ReturnId);
                    table.ForeignKey(
                        name: "FK_ReturnDetails_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnDetails_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnDetails_RentDetails_RentId",
                        column: x => x.RentId,
                        principalTable: "RentDetails",
                        principalColumn: "RentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnDetails_CarId",
                table: "ReturnDetails",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnDetails_OfficeId",
                table: "ReturnDetails",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnDetails_RentId",
                table: "ReturnDetails",
                column: "RentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnDetails_UserDetailsId",
                table: "ReturnDetails",
                column: "UserDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentDetails_AspNetUsers_Id",
                table: "RentDetails",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
