using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddFinalCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bidding_SportLocationTimeslots_SportLocationTimeSlotId",
                table: "Bidding");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_SportLocationTimeslots_SportLocationTimeslotId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SportLocationTimeslots_SportLocation_SportLocationId",
                table: "SportLocationTimeslots");

            migrationBuilder.DropForeignKey(
                name: "FK_SportLocationTimeslots_Timeslot_TimeslotId",
                table: "SportLocationTimeslots");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportLocationTimeslots",
                table: "SportLocationTimeslots");

            migrationBuilder.DropColumn(
                name: "SportLocationTimeslot1Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SportLocationTimeslot2Id",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "SportLocationTimeslots",
                newName: "SportLocationTimeslot");

            migrationBuilder.RenameIndex(
                name: "IX_SportLocationTimeslots_TimeslotId",
                table: "SportLocationTimeslot",
                newName: "IX_SportLocationTimeslot_TimeslotId");

            migrationBuilder.RenameIndex(
                name: "IX_SportLocationTimeslots_SportLocationId",
                table: "SportLocationTimeslot",
                newName: "IX_SportLocationTimeslot_SportLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportLocationTimeslot",
                table: "SportLocationTimeslot",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f758259-e189-4265-bfc0-b83eef1bc268", "AQAAAAIAAYagAAAAELNoUqiWaEaCsF8itkoXMGlVuVxVcG/fo//IhD0q/nYYjtOTC5HxVgUpayctLsgjRw==", "14481fad-ecc5-48b7-bb04-b68379319ce2" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9896), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9909), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9911), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9913), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9915), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9917), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9918), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9920), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9922), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9924), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9926), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9927), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9929), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9931), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9933), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9935), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9936), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9938), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 2, 9, 15, 57, 53, 143, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(824), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(831), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(833), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(834), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(836), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(219), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(221), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(225), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(226), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(231), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(237), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(240), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(248), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(358), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(361), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(363), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(364), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(433), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(436), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(438), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(439), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(441), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(443), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(445), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(446), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(450), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(453), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(455), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(456), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(458), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(459), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(461), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(463), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(585), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(587), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(588), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(590), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(591), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(593), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(595), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(596), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(598), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(599), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(601), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 2, 9, 15, 57, 53, 144, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslotId1",
                table: "Bookings",
                column: "SportLocationTimeslotId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslotId2",
                table: "Bookings",
                column: "SportLocationTimeslotId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Bidding_SportLocationTimeslot_SportLocationTimeSlotId",
                table: "Bidding",
                column: "SportLocationTimeSlotId",
                principalTable: "SportLocationTimeslot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocationTimeslot_SportLocationTimeslotId1",
                table: "Bookings",
                column: "SportLocationTimeslotId1",
                principalTable: "SportLocationTimeslot",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_SportLocationTimeslot_SportLocationTimeslotId2",
                table: "Bookings",
                column: "SportLocationTimeslotId2",
                principalTable: "SportLocationTimeslot",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_SportLocationTimeslot_SportLocationTimeslotId",
                table: "Schedules",
                column: "SportLocationTimeslotId",
                principalTable: "SportLocationTimeslot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SportLocationTimeslot_SportLocation_SportLocationId",
                table: "SportLocationTimeslot",
                column: "SportLocationId",
                principalTable: "SportLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SportLocationTimeslot_Timeslot_TimeslotId",
                table: "SportLocationTimeslot",
                column: "TimeslotId",
                principalTable: "Timeslot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bidding_SportLocationTimeslot_SportLocationTimeSlotId",
                table: "Bidding");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslot_SportLocationTimeslotId1",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_SportLocationTimeslot_SportLocationTimeslotId2",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_SportLocationTimeslot_SportLocationTimeslotId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SportLocationTimeslot_SportLocation_SportLocationId",
                table: "SportLocationTimeslot");

            migrationBuilder.DropForeignKey(
                name: "FK_SportLocationTimeslot_Timeslot_TimeslotId",
                table: "SportLocationTimeslot");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslotId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SportLocationTimeslotId2",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SportLocationTimeslot",
                table: "SportLocationTimeslot");

            migrationBuilder.RenameTable(
                name: "SportLocationTimeslot",
                newName: "SportLocationTimeslots");

            migrationBuilder.RenameIndex(
                name: "IX_SportLocationTimeslot_TimeslotId",
                table: "SportLocationTimeslots",
                newName: "IX_SportLocationTimeslots_TimeslotId");

            migrationBuilder.RenameIndex(
                name: "IX_SportLocationTimeslot_SportLocationId",
                table: "SportLocationTimeslots",
                newName: "IX_SportLocationTimeslots_SportLocationId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_SportLocationTimeslots",
                table: "SportLocationTimeslots",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b81513e5-8416-4a1e-a152-5ac2eab982cd", "AQAAAAIAAYagAAAAECWiI+JsU7gETS4ZO3Alix+3lDbW9W38s0aacSS4zx+RkxGR3MADK6bRtanxdoheRA==", "2ff655a3-2c8c-43a7-b8a0-a2bbf0cfc691" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4018), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4022), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4026), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4030), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4034), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4039), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4043), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4047), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4055), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4059), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4063), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4067), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4071), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4075), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4079), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4087), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5621), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5635), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5639), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5643), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4651), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4656), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4664), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4668), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4672), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4680), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4684), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4788), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4793), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4796), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4800), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4804), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4808), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4812), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4816), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4820), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5066), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5070), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5074), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5077), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5081), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5085), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5089), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5093), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5096), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5100), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5104), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5112), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5116), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5120), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5124), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5128), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5131), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5135), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5139), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5143), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5147), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5154), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5407), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5414), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5418), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5425), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5429), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5432), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5436), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 2, 8, 12, 25, 31, 954, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslot1Id",
                table: "Bookings",
                column: "SportLocationTimeslot1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportLocationTimeslot2Id",
                table: "Bookings",
                column: "SportLocationTimeslot2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bidding_SportLocationTimeslots_SportLocationTimeSlotId",
                table: "Bidding",
                column: "SportLocationTimeSlotId",
                principalTable: "SportLocationTimeslots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_SportLocationTimeslots_SportLocationTimeslotId",
                table: "Schedules",
                column: "SportLocationTimeslotId",
                principalTable: "SportLocationTimeslots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SportLocationTimeslots_SportLocation_SportLocationId",
                table: "SportLocationTimeslots",
                column: "SportLocationId",
                principalTable: "SportLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SportLocationTimeslots_Timeslot_TimeslotId",
                table: "SportLocationTimeslots",
                column: "TimeslotId",
                principalTable: "Timeslot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
