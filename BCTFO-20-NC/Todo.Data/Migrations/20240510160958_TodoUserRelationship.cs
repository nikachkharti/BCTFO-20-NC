using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class TodoUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5726c34b-6514-4ce5-92d2-0fea5065772d", "AQAAAAIAAYagAAAAEKGUcc+UCsLk2LIl84xDRgwY6vkcASn8bCvPptnifMwMevDE6YrUZVo5MSsaTkbvww==", "ed7773ca-e076-46ba-bdda-7eb863f66690" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af4225f-e668-4835-b658-598470325978", "AQAAAAIAAYagAAAAELavgV2/8PtkuTnK86Tuytm002YrLGp5MVUfwb4i48oEc3SdwZcoGG6rgHCIG517ZA==", "eee6cd2c-e4c8-4346-af09-f12721f53a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7560cf86-0f2d-42d9-b920-96ead67e46c2", "AQAAAAIAAYagAAAAEGBsqHOVK7/PXjbP2mPrwJ4LCgG1ok/PlTdnTF2wiIVeM8MDiKC/HG2XNOqRkuBafA==", "821c2a03-0b19-471d-babd-db82b7d98199" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 9, 58, 73, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2206), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 9, 58, 73, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2220), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 9, 58, 73, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2222), "D514EDC9-94BB-416F-AF9D-7C13669689C9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2225), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2228), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2228), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2230), "87746F88-DC38-4756-924A-B95CFF3A1D8A" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                values: new object[] { "7dd2fa8d-de6d-43ed-89ba-4638b8c6d1aa", "AQAAAAIAAYagAAAAEAPa1RYps6l7XzttMthm70GOW/3r9BrvswjcncLQsSa7T85BxWH9W4kwwsD9jBPheQ==", "f54d0627-9d4c-4698-afe2-527aa0f6e5ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d377c2c-b601-41af-ba91-145f5b9923c9", "AQAAAAIAAYagAAAAEKxEsrp70QiKOnmSGgTzD0GvQlZf+4BZunhSBIISoIIOl8NNgOvm0VzHZkT4c0zCJg==", "7c89de0e-0c31-4f0c-8489-be87337ab737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e49a24f-33c4-4d0a-b8d9-e7c0f69f26f3", "AQAAAAIAAYagAAAAEHudFTnne0AIuA4q72fI0qgtKtsqEZ13XQHt88w8Wt+RmAufJTtCpO/qlSokOtSrdw==", "4179a0df-5f79-495d-9166-37949ad13cd8" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 28, 31, 70, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 28, 31, 70, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 1, 28, 31, 70, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 5, 7, 20, 28, 31, 70, DateTimeKind.Local).AddTicks(712) });
        }
    }
}
