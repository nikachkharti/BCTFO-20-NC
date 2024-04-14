using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniquePin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Guests_PersonalNumber",
                table: "Guests",
                column: "PersonalNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guests_PersonalNumber",
                table: "Guests");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 4, 22, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 5, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6493), new DateTime(2024, 5, 2, 20, 44, 4, 397, DateTimeKind.Local).AddTicks(6493) });
        }
    }
}
