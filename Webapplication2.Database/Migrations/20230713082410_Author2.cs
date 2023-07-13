using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class Author2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "vinuka", "navod" },
                    { 2, "kavindu", "hasintha" },
                    { 3, "pravindu", "bhashitha" },
                    { 4, "Nethmi", "anjani" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4466), " B", new DateTime(2023, 7, 19, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4466), 1, "row 2" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Animal", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 0, 1, new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4440), " A", new DateTime(2023, 7, 18, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4461), 2, "row 1 " });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Animal", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 0, 3, new DateTime(2023, 7, 13, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4467), "C", new DateTime(2023, 7, 20, 13, 54, 10, 281, DateTimeKind.Local).AddTicks(4468), 2, "row 3 " });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { new DateTime(2023, 7, 13, 12, 28, 5, 189, DateTimeKind.Local).AddTicks(5425), " siriyawathi gana", new DateTime(2023, 7, 18, 12, 28, 5, 189, DateTimeKind.Local).AddTicks(5436), 2, "Apatath Dawasaka Ira Payado hichchi putheeee.... " });
        }
    }
}
