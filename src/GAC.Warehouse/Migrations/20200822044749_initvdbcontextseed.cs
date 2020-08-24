using Microsoft.EntityFrameworkCore.Migrations;

namespace GAC.Warehouse.Migrations
{
    public partial class initvdbcontextseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "ID", "EmailID", "Name", "PhoneNumber", "Rating" },
                values: new object[] { 1, "vendor1@gmail.com", "Vendor1", "1234567890", 9 });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "ID", "EmailID", "Name", "PhoneNumber", "Rating" },
                values: new object[] { 2, "vendor2@gmail.com", "Vendor2", "1234567891", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
