using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class RelationOTM_EmpDevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Emp_Id",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_Emp_Id",
                table: "Devices",
                column: "Emp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Employees_Emp_Id",
                table: "Devices",
                column: "Emp_Id",
                principalTable: "Employees",
                principalColumn: "Emp_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Employees_Emp_Id",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_Emp_Id",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Emp_Id",
                table: "Devices");
        }
    }
}
