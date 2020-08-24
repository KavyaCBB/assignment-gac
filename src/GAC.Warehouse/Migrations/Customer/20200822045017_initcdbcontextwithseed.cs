using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GAC.Warehouse.Migrations.Customer
{
    public partial class initcdbcontextwithseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "EmailID", "Name", "PhoneNumber" },
                values: new object[] { 1, "uncle@gmail.com", "CustomerA", "1234567890" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "EmailID", "Name", "PhoneNumber" },
                values: new object[] { 2, "bob@gmail.com", "CustomerB", "1234567891" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
