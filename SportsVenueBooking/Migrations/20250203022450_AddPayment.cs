using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardBrand",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "LastFourDigits",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "StripeChargeId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "StripeReceiptUrl",
                table: "Payment");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Payment",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryDate",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameOnCard",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NameOnCard",
                table: "Payment");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "CardBrand",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastFourDigits",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripeChargeId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripeReceiptUrl",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ab2b1b-489c-4ecf-9ca9-db8f0ac7e617", "AQAAAAIAAYagAAAAEMs8a2chLTThjrfFG8OP34gEG34wIrWcalLnwNbsvreQopUaYdnyIye0Nxqs018d2Q==", "eab716b7-e6b8-402d-9663-606073a0bb9d" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1477), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1511), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1517), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1524), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1530), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1536), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1549), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1555), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1561), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1567), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1579), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1592), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1671), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1678), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1685), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1691), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4171), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4187), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4194), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4201), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4207), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2589), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2598), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2605), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2611), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2617), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2623), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2629), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2635), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2671), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2677), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2683), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2689), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2695), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3037), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3044), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3051), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3057), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3069), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3075), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3087), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3093), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3105), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3116), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3128), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3134), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3146), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3152), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3158), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3169), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "SportLocation",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3175), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3754), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3761), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3767), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3772), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3778), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3783), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3789), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3795), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3800), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3806), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3812), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Timeslot",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3818), new DateTime(2025, 2, 3, 10, 14, 49, 807, DateTimeKind.Local).AddTicks(3820) });
        }
    }
}
