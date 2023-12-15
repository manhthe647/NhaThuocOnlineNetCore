using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class addBrandColumnForProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Stada", new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Nadyphar", new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedAt", "UpdatedAt" },
                values: new object[] { "KUDOS", new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sirio Pharma", new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 13, 22, 54, 52, 320, DateTimeKind.Local).AddTicks(5718) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1448), new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1464) });
        }
    }
}
