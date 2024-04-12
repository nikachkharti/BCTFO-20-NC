using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhyisicalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsFree = table.Column<bool>(type: "bit", nullable: false),
                    DailyPrice = table.Column<double>(type: "float", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestReservations_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "FirstName", "LastName", "PersonalNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Nikoloz", "Chkhartishvili", "01024085083", "555337681" },
                    { 2, "Khatia", "Burduli", "01024082203", "579057747" },
                    { 3, "Erekle", "Davitashvili", "12345678947", "571058998" },
                    { 4, "Dali", "Goderdzishvili", "87005633698", "555887469" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "Name", "PhyisicalAddress", "Rating" },
                values: new object[,]
                {
                    { 1, "თბილისი", "საქართველო", "პირველი სასტუმრო", "რუსთაველის 4", 10.0 },
                    { 2, "თბილისი", "საქართველო", "მეორე სასტუმრო", "პეკინის 13", 8.0 },
                    { 3, "ბათუმი", "საქართველო", "მესამე სასტუმრო", "გამსახურდიას 12", 7.7000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 4, 22, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6470) },
                    { 2, new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 5, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6475) },
                    { 3, new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6493), new DateTime(2024, 5, 2, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6493) }
                });

            migrationBuilder.InsertData(
                table: "GuestReservations",
                columns: new[] { "Id", "GuestId", "ReservationId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "FirstName", "HotelId", "LastName" },
                values: new object[,]
                {
                    { 1, "გიორგი", 1, "გიორგაძე" },
                    { 2, "თამაზი", 2, "გოდერძიშვილი" },
                    { 3, "გოირგი", 3, "გუჯარელიძე" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DailyPrice", "HotelId", "IsFree", "Name" },
                values: new object[,]
                {
                    { 1, 50.0, 1, false, "A-100" },
                    { 2, 50.0, 1, false, "A-200" },
                    { 3, 50.0, 1, true, "A-300" },
                    { 4, 100.0, 1, true, "B-100" },
                    { 5, 100.0, 1, false, "B-200" },
                    { 6, 100.0, 1, false, "B-300" },
                    { 7, 200.0, 1, true, "C-100" },
                    { 8, 200.0, 1, false, "C-200" },
                    { 9, 200.0, 1, false, "C-300" },
                    { 10, 25.0, 2, true, "100" },
                    { 11, 25.0, 2, true, "101" },
                    { 12, 25.0, 2, false, "102" },
                    { 13, 50.0, 2, true, "200" },
                    { 14, 50.0, 2, false, "201" },
                    { 15, 50.0, 2, false, "202" },
                    { 16, 75.0, 2, true, "300" },
                    { 17, 75.0, 2, true, "301" },
                    { 18, 75.0, 2, true, "302" },
                    { 19, 150.0, 3, false, "A-10" },
                    { 20, 150.0, 3, true, "A-20" },
                    { 21, 150.0, 3, true, "A-30" },
                    { 22, 150.0, 3, false, "B-10" },
                    { 23, 150.0, 3, false, "B-20" },
                    { 24, 150.0, 3, true, "B-30" },
                    { 25, 150.0, 3, true, "C-10" },
                    { 26, 150.0, 3, false, "C-20" },
                    { 27, 150.0, 3, true, "C-30" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestReservations_GuestId",
                table: "GuestReservations",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestReservations_ReservationId",
                table: "GuestReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_HotelId",
                table: "Managers",
                column: "HotelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestReservations");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
