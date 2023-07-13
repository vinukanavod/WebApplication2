using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class AuthorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Todoomommies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Hello Machan KOhomada IThin.....");

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Animal", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 0, new DateTime(2023, 7, 13, 12, 28, 5, 189, DateTimeKind.Local).AddTicks(5425), " siriyawathi gana", new DateTime(2023, 7, 18, 12, 28, 5, 189, DateTimeKind.Local).AddTicks(5436), 2, "Apatath Dawasaka Ira Payado hichchi putheeee.... " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Todoomommies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Hello Machan KOhomada IThin.");

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Animal", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 0, new DateTime(2023, 7, 12, 11, 40, 26, 259, DateTimeKind.Local).AddTicks(2900), " siriyawathi gana", new DateTime(2023, 7, 17, 11, 40, 26, 259, DateTimeKind.Local).AddTicks(2912), 2, "Apatath Dawasaka Ira Payado hichchi putheeee. " });
        }
    }
}
