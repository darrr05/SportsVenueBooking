using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddBookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancellationDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancellationDate",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb5e05ea-a058-4595-ad7b-77860c508c78", "AQAAAAIAAYagAAAAEKI5liUsPBJoeLiKzn6WzpGWTZVmItsqVobCxCJnH1gys+RRczaBB64meFJPHU5qOw==", "3903e75a-4c1d-4f9e-bf02-daaa16f8cf11" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9905), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9908), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9911), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9914), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9918), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9921), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9924), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9927), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9930), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9933), new DateTime(2025, 2, 3, 10, 24, 48, 603, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(105), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(108), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(111), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(117), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(120), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1306), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1320), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1326), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(517), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(524), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(527), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(530), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(533), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(536), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(545), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(558), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(564), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(567), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(744), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(747), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(750), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(753), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(756), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(762), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(772), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(777), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(780), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(783), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(786), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(790), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(793), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(796), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(799), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(802), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(808), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(814), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(817), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(991), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(994), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1000), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1003), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1006), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1009), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1011), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1014), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1017), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1020), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1104), new DateTime(2025, 2, 3, 10, 24, 48, 604, DateTimeKind.Local).AddTicks(1105) });
        }
    }
}
