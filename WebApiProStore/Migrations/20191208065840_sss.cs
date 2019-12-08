using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationProducts");

            migrationBuilder.DropTable(
                name: "ApplicationShoppingBags");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBags",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    NameProduct = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBags", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingBags");

            migrationBuilder.CreateTable(
                name: "ApplicationProducts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationShoppingBags",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    NameProduct = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationShoppingBags", x => x.Id);
                });
        }
    }
}
