using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddAdminAccont : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "City", "CompanyName", "Country", "Email", "Password" },
                values: new object[] { 1, "HCM", "DanielNg", "VN", "admin@fstore.com", "admin@@" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1);
        }
    }
}
