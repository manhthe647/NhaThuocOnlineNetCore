using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NhaThuocOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AppStaffAccounts",
                columns: new[] { "Id", "CreatedAt", "Dob", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Salt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2140), new DateTime(1990, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John", "Doe", "password123", "1234567890", "admin", "somesalt123", "johndoe" },
                    { 2, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2152), new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "janesmith@example.com", "Jane", "Smith", "pass4321", "9876543210", "user", "somesalt456", "janesmith" },
                    { 3, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2153), new DateTime(1982, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaeljohnson@example.com", "Michael", "Johnson", "qwerty123", "5551234567", "user", "somesalt789", "michaeljohnson" },
                    { 4, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2155), new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilydavis@example.com", "Emily", "Davis", "password456", "1112223333", "user", "somesaltabc", "emilydavis" },
                    { 5, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2156), new DateTime(1998, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "andrewwilson@example.com", "Andrew", "Wilson", "pass1234", "7778889999", "admin", "somesaltxyz", "andrewwilson" },
                    { 6, new DateTime(2023, 12, 3, 18, 56, 21, 314, DateTimeKind.Local).AddTicks(2158), new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmabrown@example.com", "Emma", "Brown", "abc123", "4445556666", "user", "somesalt789", "emmabrown" }
                });

            migrationBuilder.InsertData(
                table: "AppStaffRoles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator role with full access", "Quản trị" },
                    { 2, "Standard user role with limited access", "Nhân viên bán hàng" },
                    { 3, "Tư vấn đơn thuốc", "Dược sĩ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppStaffAccounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppStaffRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppStaffRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppStaffRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<DateTime>(
                name: "Salt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
