using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class editProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Chăm sóc sức khỏe", "Chăm sóc sức khỏe", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4049), 0, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Sản phẩm tiện lợi", "Sản phẩm tiện lợi", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4051), 0, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Thực phẩm chức năng", "Thực phẩm chức năng", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Thuốc kê đơn", "Thuốc kê đơn", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4054), 1, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Thuốc không kê đơn", "Thuốc không kê đơn", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4056), 1, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Thực phẩm dinh dưỡng", "Thực phẩm dinh dưỡng", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4058), 2, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Tai mũi họng", "Tai mũi họng", new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4059), 2, new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(3974), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4008), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4009) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Thuốc kê đơn", "Thuốc kê đơn", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8995), 1, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Thuốc không kê đơn", "Thuốc không kê đơn", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8997), 1, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chăm sóc cá nhân", "Chăm sóc cá nhân", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Khử mùi", "Khử mùi", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8999), 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Tóc", "Tóc", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9000), 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Răng miệng", "Răng miệng", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9002), 4, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryDescription", "CategoryName", "CreatedAt", "ParentId", "UpdatedAt" },
                values: new object[] { "Sản phẩm tiện lợi", "Sản phẩm tiện lợi", new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9003), 0, new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 12, 15, 18, 46, 24, 159, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductInCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

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
    }
}
