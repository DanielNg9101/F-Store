using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedingTestingAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "City", "CompanyName", "Country", "Email", "Password" },
                values: new object[] { 2, "HCM", "DanielNg", "VN", "a", "a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2);
        }
    }
}
