using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class AddZvizokwithshopanduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShoppingBags",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBags_UserId",
                table: "ShoppingBags",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_UserId",
                table: "ShoppingBags");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingBags_UserId",
                table: "ShoppingBags");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShoppingBags",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
