using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class TodosUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21362261-f7e1-403a-a243-c20607d5e458", "AQAAAAIAAYagAAAAEB+DOlnXJw4+CRGNXCRtCo2TkC88fy4W+KNgCwc0XWp/CpMWi35byktv2nhmcvrW7g==", "094ccabf-1769-4d67-b069-3c4c5b10fa9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7da1f75b-3866-478c-ab27-b1ba84f52284", "AQAAAAIAAYagAAAAEIlN2jYx+24bIVnao4Zl/QEbIYxylm/hzWo1mmy4szrqj6iWtQlGdHT3heOBg78xUg==", "7bb4f2d3-586e-4657-85af-9263d17c60a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61fb9a8d-9c4a-44a8-b0eb-0f55c03336d0", "AQAAAAIAAYagAAAAEC0T7apK66v/ayi3NNTij8o8/dd02S9K8ojP6qEQMp75huYPgQVAkRtY4ClgIWnQYA==", "9d796298-9743-4c63-a334-f10958ea7f15" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 6, 39, 936, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2137), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 6, 39, 936, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2144), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 6, 39, 936, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2146), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2148), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2152), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2152), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2154), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "429d404b-4aed-4d4b-ad4f-8514a86747c3", "AQAAAAIAAYagAAAAECVa+C0bsi1msciQjJkmE1r8jJOeOeY23TyJ8nSyLVEzJnK3+h305Z98fxDv0G2gXg==", "b9226e84-e318-4ca2-8663-5aae5ad93975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47375a8e-83bb-4515-a82e-af3431369db9", "AQAAAAIAAYagAAAAEF6hHBaSg7YfGI+ZbhPd4neGz1Zu6ARCx3/x04WCt0Ijod8f0C1UXAt3nG53l/A9Fg==", "c83a4cbb-7a9d-463a-8103-6e818c02fd10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4068758c-461d-484c-b09c-a482ed177b21", "AQAAAAIAAYagAAAAELVdFgYouQukC+XprQ/+Wa+/lH2sYLPzGvB+yEddMhY/zzncvjiLowZX1VO+KpNihw==", "54fa3729-3fc1-414f-9179-5dc7cc0534a4" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 10, 14, 188, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 10, 14, 188, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 20, 10, 14, 188, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 5, 7, 15, 10, 14, 188, DateTimeKind.Local).AddTicks(827) });
        }
    }
}
