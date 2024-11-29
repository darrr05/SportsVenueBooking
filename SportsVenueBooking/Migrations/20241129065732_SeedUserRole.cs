using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Sport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 11, 29, 14, 52, 37, 770, DateTimeKind.Local).AddTicks(9231) });
        }
    }
}
