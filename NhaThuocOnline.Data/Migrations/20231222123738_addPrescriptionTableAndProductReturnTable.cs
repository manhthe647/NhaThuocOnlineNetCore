using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPrescriptionTableAndProductReturnTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductReturns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ReturnReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReturn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReturns", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "ProductReturns");

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ExpireDate", "ManufacturingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CouponEndDate", "CouponStartDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9143) });
        }
    }
}
