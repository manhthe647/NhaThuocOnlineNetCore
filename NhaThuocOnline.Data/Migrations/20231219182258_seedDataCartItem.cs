using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4854), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4857), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4833), new DateTime(2023, 12, 20, 1, 22, 58, 531, DateTimeKind.Local).AddTicks(4833) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8086), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8089), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8091), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 12, 20, 1, 20, 43, 900, DateTimeKind.Local).AddTicks(8063) });
        }
    }
}
