using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class Maintenace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    Main_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Main_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Main_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dev_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.Main_ID);
                    table.ForeignKey(
                        name: "FK_Maintenance_Devices_Dev_Id",
                        column: x => x.Dev_Id,
                        principalTable: "Devices",
                        principalColumn: "Dev_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_Dev_Id",
                table: "Maintenance",
                column: "Dev_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenance");
        }
    }
}
