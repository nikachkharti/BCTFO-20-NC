using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descrtiption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Descrtiption", "EndDate", "Priority", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "პირველი საქმის აღწერა...", new DateTime(2024, 4, 30, 21, 55, 31, 353, DateTimeKind.Local).AddTicks(132), 2, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(132), 1, "პირველი საქმე" },
                    { 2, "მეორე საქმის აღწერა...", new DateTime(2024, 4, 30, 21, 55, 31, 353, DateTimeKind.Local).AddTicks(140), 1, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(139), 1, "მეორე საქმე" },
                    { 3, "მესამე საქმის აღწერა...", new DateTime(2024, 5, 1, 1, 55, 31, 353, DateTimeKind.Local).AddTicks(142), 4, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(141), 2, "მესამე საქმე" },
                    { 4, "მეოთხე საქმის აღწერა...", new DateTime(2024, 5, 7, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(144), 1, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(144), 1, "მეოთხე საქმე" },
                    { 5, "მეხუთე საქმის აღწერა...", new DateTime(2024, 5, 3, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(148), 3, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(148), 1, "მეხუთე საქმე" },
                    { 6, "მეექვსე საქმის აღწერა...", new DateTime(2024, 5, 10, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(150), 2, new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(150), 2, "მეექვსე საქმე" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
