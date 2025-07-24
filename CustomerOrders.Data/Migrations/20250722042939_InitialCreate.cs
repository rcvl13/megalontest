using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerOrders.Data.Migrations
{

    public partial class InitialCreate : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    DOB = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "DOB", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"), new DateTime(1986, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Smith" },
                    { new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"), new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "ItemName", "ItemPrice" },
                values: new object[,]
                {
                    { 1, new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"), "Nail Polish", 100.00m },
                    { 2, new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"), "Hair Brush", 500.00m },
                    { 3, new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"), "Shaving Cream", 90.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
