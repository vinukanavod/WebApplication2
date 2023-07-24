using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    public partial class TodayPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberofStudents = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 22, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 7, 27, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 22, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 7, 28, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 22, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 7, 29, 13, 6, 38, 530, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "ClassName", "NumberofStudents" },
                values: new object[,]
                {
                    { 1, "nena", 23 },
                    { 2, "guna", 34 },
                    { 3, "bala", 44 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "ClassId", "country", "name" },
                values: new object[,]
                {
                    { 1, 1, "sri lanka", "vinuka" },
                    { 2, 2, "india", "kavindu" },
                    { 3, 3, "sri lanka", "pasan" },
                    { 4, 1, "pakisthan", "laki" },
                    { 5, 1, "india", "lokaya" },
                    { 6, 1, "sri lanka", "batta" },
                    { 7, 3, "india", "kav" },
                    { 8, 3, "sri lanka", "chamith" },
                    { 9, 1, "pakisthan", "supun" },
                    { 10, 1, "india", "sahan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_ClassId",
                table: "students",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1497), new DateTime(2023, 7, 19, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 7, 20, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 7, 21, 11, 22, 58, 423, DateTimeKind.Local).AddTicks(1514) });
        }
    }
}
