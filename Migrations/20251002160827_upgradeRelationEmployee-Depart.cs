using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class upgradeRelationEmployeeDepart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Dep_Id",
                table: "Employees",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Dep_Id",
                table: "Employees",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "Dep_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Dep_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Dep_Id",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDep_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDep_Id",
                table: "Employees",
                column: "DepartmentDep_Id");

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
