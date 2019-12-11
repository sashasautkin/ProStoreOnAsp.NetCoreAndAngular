using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class Addnewcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameProduct",
                table: "ShoppingBags",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ShoppingBags",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ShoppingBags");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ShoppingBags",
                newName: "NameProduct");
        }
    }
}
