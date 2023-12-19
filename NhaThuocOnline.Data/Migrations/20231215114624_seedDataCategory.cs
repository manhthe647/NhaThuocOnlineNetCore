using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductInCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInCategories",
                table: "ProductInCategories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "CreatedAt", "ImagePath", "IsActive", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Dược phẩm", "Dược phẩm", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8993), "path/to/image", true, 0, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8994) },
                    { 2, "Thuốc kê đơn", "Thuốc kê đơn", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8995), "path/to/image", true, 1, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8996) },
                    { 3, "Thuốc không kê đơn", "Thuốc không kê đơn", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8997), "path/to/image", true, 1, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8997) },
                    { 4, "Chăm sóc cá nhân", "Chăm sóc cá nhân", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8998), "path/to/image", true, 0, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8998) },
                    { 5, "Khử mùi", "Khử mùi", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8999), "path/to/image", true, 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8999) },
                    { 6, "Tóc", "Tóc", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9000), "path/to/image", true, 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9001) },
                    { 7, "Răng miệng", "Răng miệng", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9002), "path/to/image", true, 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9002) },
                    { 8, "Sản phẩm tiện lợi", "Sản phẩm tiện lợi", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9003), "path/to/image", true, 0, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9003) },
                    { 9, "Hàng tổng hợp", "Hàng tổng hợp", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9004), "path/to/image", true, 8, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9004) }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "Id", "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 1, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8972), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8976) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInCategories",
                table: "ProductInCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductInCategories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5718) });
        }
    }
}
