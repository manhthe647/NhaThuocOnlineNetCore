using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiscountType",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountValue",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Coupons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8278), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "CouponDescription", "CouponEndDate", "CouponStartDate", "CreatedAt", "DiscountType", "DiscountValue", "IsActive", "MaxUsage", "TimesUsed", "UpdatedAt" },
                values: new object[] { 1, "BANMOI", "KHUYEN MAI LAN DAU", new DateTime(2023, 12, 31, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8395), "co-dinh", 50m, true, 1, 0, new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8243), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8246), new DateTime(2023, 12, 17, 21, 23, 12, 449, DateTimeKind.Local).AddTicks(8247) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DiscountType",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Coupons");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4058), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4059), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 12, 17, 15, 28, 26, 671, DateTimeKind.Local).AddTicks(4061) });

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
    }
}
