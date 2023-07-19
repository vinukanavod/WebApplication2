using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class Authorupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 5, "Nethmi", "Nishara" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 7, 19, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 7, 20, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 7, 21, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2487) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 7, 18, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4466), new DateTime(2023, 7, 19, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 7, 20, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4468) });
        }
    }
}
