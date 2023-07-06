using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Animal", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 2, new DateTime(2023, 7, 6, 14, 32, 53, 809, DateTimeKind.Local).AddTicks(5847), "ME kathawen kiyawenne siriyawathi gana", new DateTime(2023, 7, 13, 14, 32, 53, 809, DateTimeKind.Local).AddTicks(5858), 2, "Apatath Dawasaka Ira Payado - DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
