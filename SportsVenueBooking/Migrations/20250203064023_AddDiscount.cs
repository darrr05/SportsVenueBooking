using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    MaxUses = table.Column<int>(type: "int", nullable: false),
                    UsageCount = table.Column<int>(type: "int", nullable: false),
                    IsElderlyDiscount = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36f95e19-985d-44c2-a867-b143b4664d49", "AQAAAAIAAYagAAAAEPoJQbEeWoyQneS54vkLkD3mKAX53tKfxeDa0E4tH/7Ufvb20wLKgOqyhFvl7RWNuA==", "43a4190b-623c-4304-815d-fcae8a736c3c" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7131), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7153), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7159), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7166), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7175), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7178), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7184), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7187), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7196), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7199), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7202), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7205), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8548), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8557), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8560), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8564), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8567), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7628), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7634), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7637), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7640), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7643), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7646), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7649), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7652), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7658), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7661), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7667), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7670), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7673), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7676), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7679), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7849), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7855), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7858), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7864), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7867), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7870), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7876), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7882), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7885), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7888), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7891), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7894), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7897), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7903), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8138), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8141), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8144), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8147), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8150), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8153), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8354), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8357), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8360), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8362), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8365), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8371), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8374), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8377), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8379), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8382), new DateTime(2025, 2, 3, 11, 27, 22, 500, DateTimeKind.Local).AddTicks(8383) });
        }
    }
}
