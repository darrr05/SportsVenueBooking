using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customer_CustomerId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslotId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocation_SportLocationId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Payment_BookingId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslotId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "SportLocationTimeslotId",
                table: "Bookings",
                newName: "SportLocationTimeslotId2");

            migrationBuilder.RenameColumn(
                name: "SportLocationId",
                table: "Bookings",
                newName: "SportLocationTimeslotId1");

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

            migrationBuilder.AddColumn<int>(
                name: "SportLocationTimeslot1Id",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SportLocationTimeslot2Id",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50021f79-2de7-4c9b-8616-f6eb84744461", "AQAAAAIAAYagAAAAEFedQoBZM71Et6oq65uZy616eCaoXkUsZRNSd9msp7qDBB+6BGeqJP+uftbVCqtmdg==", "a91eb351-5c71-4dde-aded-e86d7d3e3264" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4586), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4600), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4603), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4605), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4609), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4613), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4615), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4622), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4624), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4626), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4685), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4690), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5468), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5475), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5479), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5482), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4950), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4953), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4955), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4957), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4959), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4963), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4967), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4969), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4975), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4977), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4979), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4981), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4983), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4985), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4987), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4989), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4991), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5114), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5116), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5120), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5122), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5124), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5126), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5128), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5130), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5132), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5134), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5136), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5138), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5140), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5144), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5146), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5149), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5157), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5161), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5295), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5297), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5299), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5301), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5303), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5311), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5313), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5315), new DateTime(2025, 2, 6, 16, 25, 34, 634, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingId",
                table: "Payment",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslot1Id",
                table: "Bookings",
                column: "SportLocationTimeslot1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslot2Id",
                table: "Bookings",
                column: "SportLocationTimeslot2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot1Id",
                table: "Bookings",
                column: "SportLocationTimeslot1Id",
                principalTable: "SportLocationTimeslots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot2Id",
                table: "Bookings",
                column: "SportLocationTimeslot2Id",
                principalTable: "SportLocationTimeslots",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Payment_BookingId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "SportLocationTimeslotId2",
                table: "Bookings",
                newName: "SportLocationTimeslotId");

            migrationBuilder.RenameColumn(
                name: "SportLocationTimeslotId1",
                table: "Bookings",
                newName: "SportLocationId");

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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingId",
                table: "Payment",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationId",
                table: "Bookings",
                column: "SportLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslotId",
                table: "Bookings",
                column: "SportLocationTimeslotId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customer_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslotId",
                table: "Bookings",
                column: "SportLocationTimeslotId",
                principalTable: "SportLocationTimeslots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocation_SportLocationId",
                table: "Bookings",
                column: "SportLocationId",
                principalTable: "SportLocation",
                principalColumn: "Id");
        }
    }
}
