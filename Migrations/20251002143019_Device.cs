using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class Device : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emp_Id",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Dev_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dev_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dev_SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dev_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dev_Quant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Dev_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.AddColumn<int>(
                name: "Emp_Id",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
