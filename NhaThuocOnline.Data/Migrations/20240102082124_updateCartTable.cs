using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExpireDate", "ManufacturingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6310), new DateTime(2025, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6217), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6273), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6178), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6192), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6194), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 1, 2, 15, 21, 24, 227, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_CategoryId",
                table: "ProductInCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductName",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductInCategories_CategoryId",
                table: "ProductInCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExpireDate", "ManufacturingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6338), new DateTime(2024, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 5, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 12, 22, 19, 37, 38, 646, DateTimeKind.Local).AddTicks(6245) });
        }
    }
}
