using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrtiption",
                table: "Todos",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dde286dd-fb4d-4b34-9ce6-9e2ef803f562", "AQAAAAIAAYagAAAAEH/MTYkLODrKJ0BTHU/M2UjrEn4RW7NYyIDttel/d2HrfeQIMk0cdVffn7PQ53tw4Q==", "72b26491-97f8-4ebc-894f-8131ad219d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "507fda87-39dd-41fc-a3ea-38975ddd7602", "AQAAAAIAAYagAAAAEPK6cZoksMqz9wXsbFjj2F6ZR4ANDr7j1pWQx2i9hXig++iNVtyR3j5myuIIFNZmgw==", "fcabbd12-a345-4b4a-8ab9-4fdd2f8389d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b1c9d4-edf6-4205-ad46-b585d9e34369", "AQAAAAIAAYagAAAAEM7lrDqFK6Lg0Q4m6+tXaCniu9WiZna03lw/5Qcm1vaTEJy+sey0Bqw2mXRFRe1vPg==", "664e11c7-3117-4664-a021-551d52c723c9" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 15, 16, 816, DateTimeKind.Local).AddTicks(2679), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 15, 16, 816, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 22, 2, 15, 16, 816, DateTimeKind.Local).AddTicks(2689), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2696), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 5, 21, 21, 15, 16, 816, DateTimeKind.Local).AddTicks(2697) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todos",
                newName: "Descrtiption");

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
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 9, 58, 73, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 9, 58, 73, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 9, 58, 73, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2228), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 10, 20, 9, 58, 73, DateTimeKind.Local).AddTicks(2230) });
        }
    }
}
