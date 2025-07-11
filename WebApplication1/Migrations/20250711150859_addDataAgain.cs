using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "Description", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Building A", "Human Resources Department", "hr@company.com", "HR", "111-111-1111" },
                    { 2, "Building B", "Information Technology Department", "it@company.com", "IT", "222-222-2222" },
                    { 3, "Building C", "Finance Department", "finance@company.com", "Finance", "333-333-3333" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "Email", "EmailAddress", "Name", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, "City Center", 1, "alice@company.com", "alice@company.com", "Alice", "111-111-1001", 5000m },
                    { 2, "East Side", 1, "bob@company.com", "bob@company.com", "Bob", "111-111-1002", 5200m },
                    { 3, "West End", 1, "charlie@company.com", "charlie@company.com", "Charlie", "111-111-1003", 4800m },
                    { 4, "North Town", 1, "diana@company.com", "diana@company.com", "Diana", "111-111-1004", 5100m },
                    { 5, "City Center", 2, "edward@company.com", "edward@company.com", "Edward", "222-222-2001", 6000m },
                    { 6, "South Side", 2, "fiona@company.com", "fiona@company.com", "Fiona", "222-222-2002", 6200m },
                    { 7, "East Side", 2, "george@company.com", "george@company.com", "George", "222-222-2003", 6100m },
                    { 8, "West End", 2, "hannah@company.com", "hannah@company.com", "Hannah", "222-222-2004", 6300m },
                    { 9, "Downtown", 3, "ian@company.com", "ian@company.com", "Ian", "333-333-3001", 5500m },
                    { 10, "City Center", 3, "julia@company.com", "julia@company.com", "Julia", "333-333-3002", 5400m },
                    { 11, "South Side", 3, "kevin@company.com", "kevin@company.com", "Kevin", "333-333-3003", 5300m },
                    { 12, "West End", 3, "laura@company.com", "laura@company.com", "Laura", "333-333-3004", 5600m }
                });
        }
    }
}
