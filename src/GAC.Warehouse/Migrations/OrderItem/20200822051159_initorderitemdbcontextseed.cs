using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GAC.Warehouse.Migrations.OrderItem
{
    public partial class initorderitemdbcontextseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "OrderID", "ProductID", "Quantity" },
                values: new object[] { 1, 1, 1, 12 });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "OrderID", "ProductID", "Quantity" },
                values: new object[] { 2, 1, 2, 1100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");
        }
    }
}
