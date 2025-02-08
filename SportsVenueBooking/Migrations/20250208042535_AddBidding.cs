using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddBidding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bidding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportLocationTimeSlotId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    AppointtedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BidAmount = table.Column<double>(type: "float", nullable: false),
                    BidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BidStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BidEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddHours = table.Column<int>(type: "int", nullable: false),
                    AddMinutes = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bidding_SportLocationTimeslots_SportLocationTimeSlotId",
                        column: x => x.SportLocationTimeSlotId,
                        principalTable: "SportLocationTimeslots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Bidding_SportLocationTimeSlotId",
                table: "Bidding",
                column: "SportLocationTimeSlotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");

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
        }
    }
}
