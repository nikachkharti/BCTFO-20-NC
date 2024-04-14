using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniquePhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(2974), new DateTime(2024, 4, 23, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(2988), new DateTime(2024, 5, 13, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 5, 3, 19, 10, 41, 999, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_PhoneNumber",
                table: "Guests",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guests_PhoneNumber",
                table: "Guests");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 4, 23, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 5, 13, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 5, 3, 19, 8, 25, 53, DateTimeKind.Local).AddTicks(6394) });
        }
    }
}
