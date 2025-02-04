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
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancellationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SportLocationId = table.Column<int>(type: "int", nullable: true),
                    SportLocationTimeslotId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Bookings_SportLocationTimeslots_SportLocationTimeslotId",
                        column: x => x.SportLocationTimeslotId,
                        principalTable: "SportLocationTimeslots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_SportLocation_SportLocationId",
                        column: x => x.SportLocationId,
                        principalTable: "SportLocation",
                        principalColumn: "Id");
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2cbb1922-5e17-4e97-89d8-0550130047b0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFCGLHUnE52apw7IZRNk8aPym3xqi7xLQtrj5kIxcP/6Z7CSWisuV3yPpUf4iE40yg==", null, false, "5b4889a2-897c-4664-8ede-a30d37899263", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "capacity" },
                values: new object[,]
                {
                    { 1, "5 Bishan St 14, Singapore 579783", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8200), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8210), "Bishan Sports Hall", "System", 5000 },
                    { 2, "57 Anchorvale Rd, Singapore 544964", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8213), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8213), "Sengkang Sports Hall", "System", 2000 },
                    { 3, "21 Jurong East St 31, Singapore 609517", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8215), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8216), "Jurong East Sports Hall", "System", 4000 },
                    { 4, "1 Tampines Walk, Singapore 528523", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8218), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8218), "Tampines Sports Hall", "System", 3500 },
                    { 5, "3 Woodlands St 13, Singapore 738600", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8220), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8221), "Woodlands Sports Hall", "System", 2500 },
                    { 6, "120 Pasir Ris Central, Singapore 519640", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8223), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8223), "Pasir Ris Sports Hall", "System", 2200 },
                    { 7, "1 Yishun Ave 3, Singapore 768101", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8225), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8226), "Yishun Sports Hall", "System", 2700 },
                    { 8, "2 Bukit Batok St 21, Singapore 659604", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8228), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8228), "Bukit Gombak Sports Hall", "System", 3000 },
                    { 9, "473 Stirling Rd, Singapore 148947", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8230), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8231), "Queenstown Sports Centre", "System", 1500 },
                    { 10, "30 Bedok North Dr, Singapore 469658", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8233), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8233), "Bedok Sports Centre", "System", 2200 },
                    { 11, "21 Canberra Link, Singapore 768137", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8235), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8236), "Bukit Canberra Sports Centre", "System", 4000 },
                    { 12, "60 Simei St 1, Singapore 529944", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8237), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8238), "Changi Simei Sports Hall", "System", 1800 },
                    { 13, "23 Serangoon North Ave 1, Singapore 555881", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8240), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8240), "Serangoon Sports Centre", "System", 2800 },
                    { 14, "900 Tiong Bahru Rd, Singapore 158790", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8242), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8243), "Delta Sports Centre", "System", 3500 },
                    { 15, "21 Choa Chu Kang Ave 4, Singapore 689812", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8245), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8245), "Choa Chu Kang Sports Centre", "System", 2500 },
                    { 16, "15 Francis Thomas Dr, Singapore 359342", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8247), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8248), "St. Andrew's Secondary School Sports Hall", "System", 800 },
                    { 17, "1 Raffles Institution Lane, Singapore 575954", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8249), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8250), "Raffles Institution Sports Hall", "System", 600 },
                    { 18, "25 Winstedt Rd, Singapore 227977", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8252), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8252), "Anglo-Chinese School Sports Hall", "System", 900 },
                    { 19, "40 Nanyang Walk, Singapore 639798", "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8254), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8255), "Nanyang Primary School Hall", "System", 500 }
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ImagePath", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8504), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8505), "images/badminton.png", "Badminton", "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8507), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8508), "images/basketball.png", "Basketball", "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8509), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8510), "images/beach_volleyball.png", "Beach Volleyball", "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8512), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8512), "images/volleyball.png", "Volleyball", "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8514), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8515), "images/dance.png", "Dance", "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8516), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8517), "images/floorball logo.jpg", "Floorball", "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8519), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8519), "images/frisbee logo.png", "Frisbee", "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8521), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8522), "images/handball.jpg", "Handball", "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8523), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8524), "images/lawnbowl.png", "Lawn Bowl", "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8526), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8526), "images/netball.jpg", "Netball", "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8528), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8529), "images/petanque.jpg", "Petanque", "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8531), "images/pickleball.jpg", "Pickleball", "System" },
                    { 13, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8533), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8534), "images/sepak.png", "Sepak", "System" },
                    { 14, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8536), "images/squash.png", "Squash", "System" },
                    { 15, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8538), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8538), "images/table_tennis.png", "Table Tennis", "System" },
                    { 16, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8540), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8541), "images/soccer.png", "Soccer", "System" },
                    { 17, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8542), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8543), "images/hockey.png", "Hockey", "System" },
                    { 18, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8545), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8545), "images/tennis.png", "Tennis", "System" }
                });

            migrationBuilder.InsertData(
                table: "Timeslot",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8981), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8982), "08:00 AM - 09:00 AM", "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8984), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8984), "09:00 AM - 10:00 AM", "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8986), "10:00 AM - 11:00 AM", "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8988), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8989), "11:00 AM - 12:00 PM", "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8990), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8991), "12:00 PM - 01:00 PM", "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8992), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8993), "01:00 PM - 02:00 PM", "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8995), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8995), "02:00 PM - 03:00 PM", "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8997), "03:00 PM - 04:00 PM", "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8999), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9000), "04:00 PM - 05:00 PM", "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9002), "05:00 PM - 06:00 PM", "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9003), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9004), "06:00 PM - 07:00 PM", "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9006), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9006), "07:00 PM - 08:00 PM", "System" }
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
                    { 1, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8689), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8690), 2, 1, "System" },
                    { 2, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8692), 1, 1, "System" },
                    { 3, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8694), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8694), 2, 2, "System" },
                    { 4, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8697), 14, 2, "System" },
                    { 5, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8698), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8699), 1, 3, "System" },
                    { 6, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8701), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8701), 17, 3, "System" },
                    { 7, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8703), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8704), 2, 4, "System" },
                    { 8, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8705), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8706), 15, 4, "System" },
                    { 9, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8708), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8708), 1, 5, "System" },
                    { 10, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8710), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8711), 16, 5, "System" },
                    { 11, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8713), 3, 6, "System" },
                    { 12, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8715), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8716), 18, 6, "System" },
                    { 13, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8717), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8718), 4, 7, "System" },
                    { 14, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8720), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8720), 5, 8, "System" },
                    { 15, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8722), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8723), 6, 9, "System" },
                    { 16, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8725), 19, 9, "System" },
                    { 17, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8727), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8727), 7, 10, "System" },
                    { 18, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8729), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8730), 8, 11, "System" },
                    { 19, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8731), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8732), 9, 12, "System" },
                    { 20, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8734), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8734), 2, 12, "System" },
                    { 21, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8736), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8737), 10, 13, "System" },
                    { 22, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8738), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8739), 11, 14, "System" },
                    { 23, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8824), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8825), 12, 15, "System" },
                    { 24, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8828), 13, 16, "System" },
                    { 25, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8829), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(8830), 14, 17, "System" }
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
                    { 1, 20, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9167), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9168), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", 0.0 },
                    { 2, 15, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9174), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "System", 0.0 },
                    { 3, 25, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9177), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9177), new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "System", 0.0 },
                    { 4, 10, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9179), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9180), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "System", 0.0 },
                    { 5, 20, "System", new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 1, 22, 12, 48, 30, 308, DateTimeKind.Local).AddTicks(9183), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "System", 0.0 }
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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "SportLocationTimeslots");

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
