using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class Adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due", "Title" },
                values: new object[] { new DateTime(2023, 7, 11, 16, 43, 3, 394, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 7, 18, 16, 43, 3, 394, DateTimeKind.Local).AddTicks(9551), "Apatath Dawasaka Ira Payado ---database" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due", "Title" },
                values: new object[] { new DateTime(2023, 7, 6, 14, 32, 53, 809, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 7, 13, 14, 32, 53, 809, DateTimeKind.Local).AddTicks(5858), "Apatath Dawasaka Ira Payado - DB" });
        }
    }
}
