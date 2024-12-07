using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e12013fc-f5a9-4782-97cd-4a1bae568c04", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENhuUs697jMq246pPU73hJ8+MzPFM6tbKJmvyWFl27tc8NC8nDjGLMKQExyzBbsSMg==", null, false, "b092cb79-fed4-4fb0-9630-47381ca4384f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(1312), new DateTime(2024, 11, 29, 15, 7, 15, 903, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(5231), new DateTime(2024, 11, 29, 14, 57, 30, 266, DateTimeKind.Local).AddTicks(5232) });
        }
    }
}
