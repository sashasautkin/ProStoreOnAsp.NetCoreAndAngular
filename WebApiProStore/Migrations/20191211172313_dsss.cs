using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class dsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ShoppingBags",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBags_ProductId",
                table: "ShoppingBags",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingBags_ProductId",
                table: "ShoppingBags");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ShoppingBags",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
