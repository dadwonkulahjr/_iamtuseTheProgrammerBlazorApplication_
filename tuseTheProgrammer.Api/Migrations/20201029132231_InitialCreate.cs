using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tuseTheProgrammer.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "david@tuseTheProgrammer.com", "David", 1, "James", "images/david.png" },
                    { 2, new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "sara@tuseTheProgrammer.com", "Sara", 2, "Peters", "images/sara.png" },
                    { 3, new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "freya@tuseTheProgrammer.com", "Freya", 2, "Holland", "images/freya.png" },
                    { 4, new DateTime(1985, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "price@tuseTheProgrammer.com", "Prince", 1, "Solo", "images/car.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
