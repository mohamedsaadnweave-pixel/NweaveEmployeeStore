using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class Deleatdepartclumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentDep_Id",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees",
                column: "DepartmentDep_Id",
                principalTable: "Departments",
                principalColumn: "Dep_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentDep_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees",
                column: "DepartmentDep_Id",
                principalTable: "Departments",
                principalColumn: "Dep_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
