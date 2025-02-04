using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d5b1f62-a189-4d49-969d-cf5245e3c968", "AQAAAAIAAYagAAAAEPTYqHmgG/yq2i6vkLTF77ts2NBp94b1EqTgAHv2clu5++HywhwYImV8GjDTqTe4gg==", "c29ca9b3-2282-4882-87b6-a7ca76e2d365" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7831), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7833), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7838), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7841), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7845), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7847), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7854), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7856), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7859), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7863), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7866), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7868), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7870), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8779), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8786), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8788), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8793), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8155), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8157), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8162), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8164), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8169), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8171), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8173), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8175), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8177), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8182), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8184), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8186), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8189), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8191), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8193), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8336), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8338), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8341), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8343), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8345), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8347), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8349), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8352), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8354), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8357), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8359), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8361), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8363), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8365), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8370), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8372), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8374), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8376), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8378), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8381), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8383), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8472), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8475), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8477), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8626), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8628), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8630), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8632), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8634), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8637), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8639), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8641), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8643), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8645), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8647), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8649), new DateTime(2025, 2, 4, 18, 22, 29, 410, DateTimeKind.Local).AddTicks(8650) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
