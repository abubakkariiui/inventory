using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryDetails",
                columns: table => new
                {
                    InventoryDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryDetails", x => x.InventoryDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryDetails");
        }
    }
}
