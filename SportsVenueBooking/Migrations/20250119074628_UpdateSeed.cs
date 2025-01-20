using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "SportLocation");

            migrationBuilder.DropColumn(
                name: "SportName",
                table: "SportLocation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "142c5617-4f61-4153-8f58-9d2676e88181", "AQAAAAIAAYagAAAAEIjsmT5QSVANP/fowWWcL5nNEoH51WlaB0RsuISk+F+XgfPCV5IhOoa3ofkb5qRFMQ==", "e69ef4ca-6f2a-456c-aad8-ab89ae0a77ce" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6926), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6936), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6939), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6946), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6950), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6960), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6963), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6966), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6969), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6973), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6976), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6979), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8528), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8532), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8538), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7391), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7394), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7399), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7402), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7404), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7409), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7411), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7413), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7416), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7418), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7420), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7515), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7520), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7523), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7661), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7663), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7666), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7668), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7670), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7672), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7675), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7677), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7679), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7686), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7691), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7696), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7698), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7700), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7702), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7705), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7707), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7709), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7711), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.InsertData(
                table: "SportLocation",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "LocationId", "SportId", "UpdatedBy" },
                values: new object[,]
                {
                    { 24, "System", new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7713), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7714), 13, 16, "System" },
                    { 25, "System", new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7716), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7716), 14, 17, "System" }
                });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7859), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7864), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7866), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7868), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7870), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7875), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7877), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7881), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 1, 19, 15, 46, 27, 541, DateTimeKind.Local).AddTicks(7884) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "SportLocation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SportName",
                table: "SportLocation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "481238c8-7403-487f-9807-91de44699335", "AQAAAAIAAYagAAAAEMXSMNXu7yQnkVa9+NgxdSs82Tgba/NjXD5Px80Zoboc5xPjrNULR9ALdZQs8zcEtw==", "411fd394-46b7-4585-ae25-cdd33365e050" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1705), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1719), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1722), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1725), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1728), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1735), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1744), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1753), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1756), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1759), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1762), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1768), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1771), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3305), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3309), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3313), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3316), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2131), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2137), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2140), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2145), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2148), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2151), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2154), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2160), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2165), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2168), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2171), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2408), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2409), "Sengkang Sports Hall", "Badminton" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2411), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2412), "Bishan Sports Hall", "Badminton" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2415), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2416), "Sengkang Sports Hall", "Basketball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2418), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2419), "Bukit Canberra Sports Centre", "Basketball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2422), "Bishan Sports Hall", "Beach Volleyball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2424), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2425), "Delta Sports Centre", "Beach Volleyball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2428), "Sengkang Sports Hall", "Volleyball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2431), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2431), "Changi Simei Sports Hall", "Volleyball" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2434), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2435), "Bishan Sports Hall", "Dance" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2438), "Serangoon Sports Centre", "Dance" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2441), "Jurong East Sports Hall", "Tennis" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2443), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2444), "Choa Chu Kang Sports Centre", "Tennis" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2446), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2447), "Tampines Sports Hall", "Table Tennis" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2449), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2450), "Woodlands Sports Hall", "Squash" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2453), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2453), "Pasir Ris Sports Hall", "Futsal" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2456), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2456), "Woodlands Sports Hall", "Futsal" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2459), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2460), "Yishun Sports Hall", "Swimming" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2462), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2463), "Bukit Gombak Sports Hall", "Gymnastics" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2466), "Queenstown Sports Centre", "Archery" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2469), "Sengkang Sports Hall", "Archery" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2471), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2472), "Bedok Sports Centre", "Football" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2474), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2475), "Bukit Canberra Sports Centre", "Hockey" });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated", "LocationName", "SportName" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2478), "Changi Simei Sports Hall", "Handball" });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2635), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2637), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2640), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2646), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2648), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2651), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2654), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2662), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2664), new DateTime(2025, 1, 19, 15, 43, 23, 209, DateTimeKind.Local).AddTicks(2665) });
        }
    }
}
