using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GAC.Warehouse.Migrations.Address
{
    public partial class initadddbcontextseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorID = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "Country", "State", "Street", "VendorID", "ZipCode" },
                values: new object[] { 1, "Bangalore", "India", "Karnataka", "Triveni Road", 1, "560021" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "Country", "State", "Street", "VendorID", "ZipCode" },
                values: new object[] { 2, "Hyderabad", "India", "Andhra", "Cord Road", 2, "121212" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
