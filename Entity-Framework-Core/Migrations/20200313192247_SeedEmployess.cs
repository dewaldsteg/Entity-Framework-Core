using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core.Migrations
{
    public partial class SeedEmployess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "password", "username" },
                values: new object[] { "1", "test@test.com", "test", "test1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "1");
        }
    }
}
