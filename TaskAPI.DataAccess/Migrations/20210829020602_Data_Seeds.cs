using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class Data_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Titel" },
                values: new object[] { 1, new DateTime(2021, 8, 29, 7, 36, 1, 704, DateTimeKind.Local).AddTicks(2227), "Description 01", new DateTime(2021, 9, 2, 7, 36, 1, 705, DateTimeKind.Local).AddTicks(161), 0, "Titel 01" });
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
