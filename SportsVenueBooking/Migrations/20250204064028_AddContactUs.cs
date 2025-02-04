using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddContactUs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86313eeb-937b-4366-9fc0-32c3a4e1d6fd", "AQAAAAIAAYagAAAAEOUPlku8o0i3UUZy5xEvIvrDICDis+A6hR/mXi7bNEBzc3g9oaKHmA+UyJ2rLjBLzQ==", "e8af14b8-6bfa-483c-8401-334cac7223a9" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7711), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7731), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7743), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7763), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7767), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7771), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7775), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7779), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7795), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9188), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9202), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9206), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9210), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8263), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8367), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8371), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8375), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8379), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8382), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8386), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8390), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8394), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8398), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8402), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8405), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8409), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8413), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8421), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8425), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8429), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8653), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8657), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8661), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8665), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8669), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8672), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8676), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8684), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8688), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8695), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8699), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8703), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8706), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8710), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8714), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8718), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8721), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8725), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8729), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8733), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8737), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8740), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8744), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8959), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8963), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8967), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8971), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8974), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8978), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8982), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9000), new DateTime(2025, 2, 4, 14, 40, 26, 800, DateTimeKind.Local).AddTicks(9001) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dde03dc9-2efe-4617-b004-57b88cd487b2", "AQAAAAIAAYagAAAAEL38LJ9ISZNsbdwGX3c5OYVj++yqs77Q/JuM1zUtNFfdY6gU1gggmQB1xsnm0/STVw==", "b4ab3f2e-84b9-4c07-b54a-609c1ffc5a70" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7984), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7986), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7988), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7992), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7997), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8002), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8004), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8006), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8008), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8011), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8015), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8017), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8019), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8021), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8023), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8839), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8845), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8848), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8852), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8294), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8297), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8299), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8301), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8303), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8305), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8307), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8309), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8311), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8313), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8315), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8317), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8320), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8322), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8324), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8326), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8328), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8330), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8499), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8501), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8503), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8505), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8507), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8509), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8511), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8513), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8515), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8517), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8520), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8522), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8524), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8526), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8528), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8530), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8532), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8534), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8536), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8538), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8540), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8542), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8544), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8546), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8548), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8683), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8685), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8687), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8689), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8693), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8695), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8697), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8699), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8701), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8703), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8705), new DateTime(2025, 2, 3, 14, 40, 22, 748, DateTimeKind.Local).AddTicks(8705) });
        }
    }
}
