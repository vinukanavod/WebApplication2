using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class AddNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 11, 23, 13, 0, 147, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 7, 18, 23, 13, 0, 147, DateTimeKind.Local).AddTicks(513) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 11, 16, 43, 3, 394, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 7, 18, 16, 43, 3, 394, DateTimeKind.Local).AddTicks(9551) });
        }
    }
}
