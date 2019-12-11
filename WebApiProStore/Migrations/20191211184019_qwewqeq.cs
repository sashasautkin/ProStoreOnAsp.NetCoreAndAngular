using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProStore.Migrations
{
    public partial class qwewqeq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FullName" },
                values: new object[,]
                {
                    { "853a7c21-cd96-4f70-a2b6-26cc7d877777", 0, "b68e4b1d-02b4-415f-b391-29359c7a793c", "User", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEIK69ry4C5Y7JCmXbtwK+mjyCmJdy65JqdDkxAtd+G26Aq8ajyUbPBe68DW5VSnO1w==", null, false, null, false, "Narkoman", null },
                    { "853a7c21-cd96-4f70-a2b6-26cc7d875111", 0, "943be57c-f66f-40b5-add8-aa5727eeeff8", "User", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEIK69ry4C5Y7JCmXbtwK+mjyCmJdy65JqdDkxAtd+G26Aq8ajyUbPBe68DW5VSnO1w==", null, false, null, false, "Alkash", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductName", "UserId", "UserName" },
                values: new object[,]
                {
                    { "sadfasdfa", 3000.0, "Car", "853a7c21-cd96-4f70-a2b6-26cc7d875177", "sasha" },
                    { "rrrrrrr", 1000.0, "Laptop", "853a7c21-cd96-4f70-a2b6-26cc7d875177", "sasha" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingBags",
                columns: new[] { "Id", "CustomerName", "Price", "ProductId", "ProductName", "UserId", "UserName" },
                values: new object[] { "wqewqeweqeqweqeqweqweqweqweq", "sasha", 3000.0, "sadfasdfa", "Car", "853a7c21-cd96-4f70-a2b6-26cc7d875177", "vania" });

            migrationBuilder.InsertData(
                table: "ShoppingBags",
                columns: new[] { "Id", "CustomerName", "Price", "ProductId", "ProductName", "UserId", "UserName" },
                values: new object[] { "wewewrergfgdwtrwerwrewew", "sasha", 3000.0, "sadfasdfa", "Car", "853a7c21-cd96-4f70-a2b6-26cc7d875177", "alla" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d875111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "853a7c21-cd96-4f70-a2b6-26cc7d877777");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "rrrrrrr");

            migrationBuilder.DeleteData(
                table: "ShoppingBags",
                keyColumn: "Id",
                keyValue: "wewewrergfgdwtrwerwrewew");

            migrationBuilder.DeleteData(
                table: "ShoppingBags",
                keyColumn: "Id",
                keyValue: "wqewqeweqeqweqeqweqweqweqweq");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "sadfasdfa");
        }
    }
}
