using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class spaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todoomommies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Todoomommies",
                columns: new[] { "Id", "Description", "Name", "number" },
                values: new object[] { 3, "Hello Machan KOhomada IThin.", "Vinuka Nvod", 714703776 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Animal", "Created", "Description", "Due", "Title" },
                values: new object[] { 0, new DateTime(2023, 7, 12, 11, 40, 26, 259, DateTimeKind.Local).AddTicks(2900), " siriyawathi gana", new DateTime(2023, 7, 17, 11, 40, 26, 259, DateTimeKind.Local).AddTicks(2912), "Apatath Dawasaka Ira Payado hichchi putheeee. " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todoomommies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Todoomommies",
                columns: new[] { "Id", "Description", "Name", "number" },
                values: new object[] { 5, "Mage nama thiyana wena aya naaaa", "VInuka Navod", 69 });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Animal", "Created", "Description", "Due", "Title" },
                values: new object[] { 2, new DateTime(2023, 7, 12, 11, 35, 15, 919, DateTimeKind.Local).AddTicks(1799), "ME kathawen kiyawenne siriyawathi gana", new DateTime(2023, 7, 19, 11, 35, 15, 919, DateTimeKind.Local).AddTicks(1813), "Apatath Dawasaka Ira Payado ---database" });
        }
    }
}
