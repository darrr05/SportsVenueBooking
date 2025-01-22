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
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timeslot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeslotDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancellationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SportLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportLocation_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StripeChargeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StripeReceiptUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastFourDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SportLocationTimeslots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportLocationId = table.Column<int>(type: "int", nullable: false),
                    TimeslotId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportLocationTimeslots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportLocationTimeslots_SportLocation_SportLocationId",
                        column: x => x.SportLocationId,
                        principalTable: "SportLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportLocationTimeslots_Timeslot_TimeslotId",
                        column: x => x.TimeslotId,
                        principalTable: "Timeslot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SportLocationTimeslotId = table.Column<int>(type: "int", nullable: false),
                    AvailableSlots = table.Column<int>(type: "int", nullable: false),
                    totalPrice = table.Column<double>(type: "float", nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_SportLocationTimeslots_SportLocationTimeslotId",
                        column: x => x.SportLocationTimeslotId,
                        principalTable: "SportLocationTimeslots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9b4fbc8c-2f67-4d0b-83e2-9c6a1f6816d3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOTkDQ0GhhApmn4NnXx8f93niSUGwgGzQduXP1XVH29P96tfkYv9KuOTkeTpdcWu2A==", null, false, "bfd8c171-4f0b-4a35-8ca8-f982dc3285c4", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "capacity" },
                values: new object[,]
                {
                    { 1, "5 Bishan St 14, Singapore 579783", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6106), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6117), "Bishan Sports Hall", "System", 5000 },
                    { 2, "57 Anchorvale Rd, Singapore 544964", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6122), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6123), "Sengkang Sports Hall", "System", 2000 },
                    { 3, "21 Jurong East St 31, Singapore 609517", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6126), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6127), "Jurong East Sports Hall", "System", 4000 },
                    { 4, "1 Tampines Walk, Singapore 528523", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6130), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6131), "Tampines Sports Hall", "System", 3500 },
                    { 5, "3 Woodlands St 13, Singapore 738600", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6134), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6135), "Woodlands Sports Hall", "System", 2500 },
                    { 6, "120 Pasir Ris Central, Singapore 519640", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6138), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6140), "Pasir Ris Sports Hall", "System", 2200 },
                    { 7, "1 Yishun Ave 3, Singapore 768101", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6143), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6144), "Yishun Sports Hall", "System", 2700 },
                    { 8, "2 Bukit Batok St 21, Singapore 659604", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6147), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6148), "Bukit Gombak Sports Hall", "System", 3000 },
                    { 9, "473 Stirling Rd, Singapore 148947", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6151), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6152), "Queenstown Sports Centre", "System", 1500 },
                    { 10, "30 Bedok North Dr, Singapore 469658", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6155), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6156), "Bedok Sports Centre", "System", 2200 },
                    { 11, "21 Canberra Link, Singapore 768137", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6159), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6160), "Bukit Canberra Sports Centre", "System", 4000 },
                    { 12, "60 Simei St 1, Singapore 529944", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6163), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6164), "Changi Simei Sports Hall", "System", 1800 },
                    { 13, "23 Serangoon North Ave 1, Singapore 555881", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6167), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6168), "Serangoon Sports Centre", "System", 2800 },
                    { 14, "900 Tiong Bahru Rd, Singapore 158790", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6171), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6172), "Delta Sports Centre", "System", 3500 },
                    { 15, "21 Choa Chu Kang Ave 4, Singapore 689812", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6175), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6176), "Choa Chu Kang Sports Centre", "System", 2500 },
                    { 16, "15 Francis Thomas Dr, Singapore 359342", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6179), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6181), "St. Andrew's Secondary School Sports Hall", "System", 800 },
                    { 17, "1 Raffles Institution Lane, Singapore 575954", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6184), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6185), "Raffles Institution Sports Hall", "System", 600 },
                    { 18, "25 Winstedt Rd, Singapore 227977", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6188), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6189), "Anglo-Chinese School Sports Hall", "System", 900 },
                    { 19, "40 Nanyang Walk, Singapore 639798", "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6192), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6193), "Nanyang Primary School Hall", "System", 500 }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ImagePath", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6821), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6823), "images/badminton.png", "Badminton", "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6827), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6828), "images/basketball.png", "Basketball", "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6831), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6832), "images/beach_volleyball.png", "Beach Volleyball", "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6836), "images/volleyball.png", "Volleyball", "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6839), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6840), "images/dance.png", "Dance", "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6844), "images/floorball logo.jpg", "Floorball", "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6847), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6848), "images/frisbee logo.png", "Frisbee", "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6851), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6852), "images/handball.jpg", "Handball", "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6856), "images/lawnbowl.png", "Lawn Bowl", "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6859), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6860), "images/netball.jpg", "Netball", "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6863), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6864), "images/petanque.jpg", "Petanque", "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6867), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6868), "images/pickleball.jpg", "Pickleball", "System" },
                    { 13, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6871), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6872), "images/sepak.png", "Sepak", "System" },
                    { 14, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6930), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6931), "images/squash.png", "Squash", "System" },
                    { 15, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6935), "images/table_tennis.png", "Table Tennis", "System" },
                    { 16, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6939), "images/soccer.png", "Soccer", "System" },
                    { 17, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6943), "images/hockey.png", "Hockey", "System" },
                    { 18, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6946), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(6947), "images/tennis.png", "Tennis", "System" }
                });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7520), "08:00 AM - 09:00 AM", "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7522), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7523), "09:00 AM - 10:00 AM", "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7526), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7527), "10:00 AM - 11:00 AM", "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7530), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7531), "11:00 AM - 12:00 PM", "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7533), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7534), "12:00 PM - 01:00 PM", "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7538), "01:00 PM - 02:00 PM", "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7541), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7542), "02:00 PM - 03:00 PM", "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7544), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7545), "03:00 PM - 04:00 PM", "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7548), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7549), "04:00 PM - 05:00 PM", "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7552), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7553), "05:00 PM - 06:00 PM", "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7555), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7556), "06:00 PM - 07:00 PM", "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7559), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7560), "07:00 PM - 08:00 PM", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "SportLocation",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "LocationId", "SportId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7194), 2, 1, "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7197), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7198), 1, 1, "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7201), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7202), 2, 2, "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7205), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7206), 14, 2, "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7209), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7210), 1, 3, "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7213), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7214), 17, 3, "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7217), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7218), 2, 4, "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7221), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7222), 15, 4, "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7225), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7226), 1, 5, "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7230), 16, 5, "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7232), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7234), 3, 6, "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7236), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7237), 18, 6, "System" },
                    { 13, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7240), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7241), 4, 7, "System" },
                    { 14, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7244), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7245), 5, 8, "System" },
                    { 15, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7248), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7249), 6, 9, "System" },
                    { 16, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7252), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7253), 19, 9, "System" },
                    { 17, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7256), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7257), 7, 10, "System" },
                    { 18, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7260), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7261), 8, 11, "System" },
                    { 19, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7264), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7265), 9, 12, "System" },
                    { 20, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7268), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7269), 2, 12, "System" },
                    { 21, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7272), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7273), 10, 13, "System" },
                    { 22, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7275), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7277), 11, 14, "System" },
                    { 23, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7279), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7281), 12, 15, "System" },
                    { 24, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7284), 13, 16, "System" },
                    { 25, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7288), 14, 17, "System" }
                });

            migrationBuilder.InsertData(
                table: "SportLocationTimeslots",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Price", "SportLocationId", "TimeslotId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1, 1, null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 1, 2, null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.0, 2, 2, null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0, 3, 3, null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65.0, 4, 4, null },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "AvailableSlots", "CreatedBy", "DateCreated", "DateUpdated", "ScheduledDate", "SportLocationTimeslotId", "UpdatedBy", "totalPrice" },
                values: new object[,]
                {
                    { 1, 20, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7762), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7763), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", 0.0 },
                    { 2, 15, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7772), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7773), new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "System", 0.0 },
                    { 3, 25, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7776), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7777), new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "System", 0.0 },
                    { 4, 10, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7780), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7782), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "System", 0.0 },
                    { 5, 20, "System", new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7785), new DateTime(2025, 1, 22, 9, 43, 31, 2, DateTimeKind.Local).AddTicks(7786), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "System", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_LocationId",
                table: "Bookings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SportId",
                table: "Bookings",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingId",
                table: "Payment",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_SportLocationTimeslotId",
                table: "Schedules",
                column: "SportLocationTimeslotId");

            migrationBuilder.CreateIndex(
                name: "IX_SportLocation_LocationId",
                table: "SportLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SportLocation_SportId",
                table: "SportLocation",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_SportLocationTimeslots_SportLocationId",
                table: "SportLocationTimeslots",
                column: "SportLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SportLocationTimeslots_TimeslotId",
                table: "SportLocationTimeslots",
                column: "TimeslotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "SportLocationTimeslots");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "SportLocation");

            migrationBuilder.DropTable(
                name: "Timeslot");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
