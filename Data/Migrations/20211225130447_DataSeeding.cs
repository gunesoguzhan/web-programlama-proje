using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "0865aff9-da9c-4b4a-a835-1e8c84743667", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "99ed5274-ad1f-4384-92dc-4c97e0e72e65", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8326f3f-91f6-4b73-874a-ed0a273fde3c", 0, "392de9b5-5c09-4b52-896e-6ac4261f8e79", "UserDetails", "g181210068@sakarya.edu.tr", true, false, null, "Admin", "G181210068@SAKARYA.EDU.TR", "G181210068@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEJ+BGADNRdwBHSbHGTTwnjgHKMHeDxwek9fLmP8KrU16DA3U/nRX+1E9Q+peOqSCgA==", null, false, "cd964fa1-f46c-4998-a12c-3180a47f8e3f", "Admin", false, "g181210068@sakarya.edu.tr" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "f8326f3f-91f6-4b73-874a-ed0a273fde3c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "f8326f3f-91f6-4b73-874a-ed0a273fde3c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8326f3f-91f6-4b73-874a-ed0a273fde3c");
        }
    }
}
