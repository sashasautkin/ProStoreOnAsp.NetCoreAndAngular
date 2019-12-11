using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class ррр : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d875111",
                column: "ConcurrencyStamp",
                value: "9706b14a-80b6-4d08-b8ad-33667e3798a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d877777",
                column: "ConcurrencyStamp",
                value: "02ac6c26-511e-42da-b34b-0feae204f068");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d875111",
                column: "ConcurrencyStamp",
                value: "943be57c-f66f-40b5-add8-aa5727eeeff8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d877777",
                column: "ConcurrencyStamp",
                value: "b68e4b1d-02b4-415f-b391-29359c7a793c");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Products_ProductId",
                table: "ShoppingBags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
