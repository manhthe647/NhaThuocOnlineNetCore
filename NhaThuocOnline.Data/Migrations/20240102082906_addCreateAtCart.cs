using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class addCreateAtCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExpireDate", "ManufacturingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9577), new DateTime(2025, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9509), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9512), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9515), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9542), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 1, 2, 15, 29, 6, 291, DateTimeKind.Local).AddTicks(9491) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Carts");

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
        }
    }
}
