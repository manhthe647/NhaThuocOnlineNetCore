using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataBatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Order");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Batches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "Id", "CreatedAt", "ExpireDate", "IsDeleted", "ManufacturingDate", "OriginPrice", "ProductId", "Quantity", "Stock", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9323), false, new DateTime(2024, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9324), 50000.0, 1, 100, 100, new DateTime(2023, 12, 20, 16, 31, 59, 58, DateTimeKind.Local).AddTicks(9330) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Batches");

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

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
    }
}
