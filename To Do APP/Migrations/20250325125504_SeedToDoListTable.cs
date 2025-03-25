using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace To_Do_APP.Migrations
{
    /// <inheritdoc />
    public partial class SeedToDoListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoLists",
                columns: new[] { "Id", "IsCompleted", "Title" },
                values: new object[,]
                {
                    { 1, true, "Project work" },
                    { 2, false, "Project work 2" },
                    { 3, true, "Project work 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDoLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ToDoLists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
