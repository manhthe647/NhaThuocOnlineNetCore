using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeInfo");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "ProductAttribute");

            migrationBuilder.DropTable(
                name: "VariantValues");

            migrationBuilder.DropTable(
                name: "Varients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoShortDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Packaging",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductionLocation",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isPrescriptionRequired",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OriginPrice = table.Column<double>(type: "float", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "DiscountPrice", "ImagePath", "Ingredients", "IsPublished", "Manufacturer", "Origin", "Packaging", "ProductName", "ProductionLocation", "RegularPrice", "SKU", "SeoAlias", "SeoTitle", "UpdatedAt", "isPrescriptionRequired" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1448), "Paracetamol 500mg là một loại thuốc giảm đau và hạ sốt thông thường được sử dụng. Nó phù hợp để giảm đau nhẹ đến vừa và hạ sốt.", 38000.0, "img/products/paracetamol500mg.jpg", "Paracetamol", true, "STADA", "Việt Nam", "Hộp 10 Vỉ x 10 Viên", "Paracetamol 500mg", "Việt Nam", 48000.0, "SKU001", "paracetamol-500mg", "Paracetamol 500mg", new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1458), false },
                    { 2, new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1460), "Ibuprofen 200mg là một loại thuốc giảm đau, hạ sốt và chống viêm thông thường được sử dụng. Nó phù hợp để giảm đau nhẹ đến vừa, hạ sốt và giảm viêm.", 45000.0, "img/products/ibuprofen200mg.jpg", "Ibuprofen", true, "ABC Company", "Việt Nam", "Hộp 20 Vỉ x 10 Viên", "Ibuprofen 200mg", "Việt Nam", 55000.0, "SKU002", "ibuprofen-200mg", "Ibuprofen 200mg", new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1461), false },
                    { 3, new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1462), "Vitamin C 1000mg là một loại vitamin tổng hợp thường được sử dụng để bổ sung nhu cầu vitamin C hàng ngày. Nó giúp tăng cường hệ miễn dịch và chống oxy hóa.", 20000.0, "img/products/vitaminc1000mg.jpg", "Vitamin C", true, "ABC Company", "Mỹ", "Hộp 30 Viên", "Vitamin C 1000mg", "Mỹ", 25000.0, "SKU003", "vitamin-c-1000mg", "Vitamin C 1000mg", new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1463), false },
                    { 4, new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1464), "Omega-3 Fish Oil là một loại bổ sung dầu cá chứa các axit béo omega-3. Nó có lợi cho sức khỏe tim mạch, não bộ và khớp.", 100000.0, "img/products/omega3fishoil.jpg", "Dầu cá omega-3", true, "XYZ Company", "Na Uy", "Chai 60 Viên", "Omega-3 Fish Oil", "Na Uy", 120000.0, "SKU004", "omega-3-fish-oil", "Omega-3 Fish Oil", new DateTime(2023, 12, 13, 17, 35, 37, 585, DateTimeKind.Local).AddTicks(1464), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Packaging",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionLocation",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "isPrescriptionRequired",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SeoShortDescription",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AttributeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AttributeValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Sorted = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                columns: table => new
                {
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VariantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    VarientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varients", x => x.Id);
                });
        }
    }
}
