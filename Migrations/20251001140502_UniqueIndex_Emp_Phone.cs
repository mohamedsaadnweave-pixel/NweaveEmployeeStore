using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class UniqueIndex_Emp_Phone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Emp_Phone",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentDep_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Emp_Phone",
                table: "Employees",
                column: "Emp_Phone",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees",
                column: "DepartmentDep_Id",
                principalTable: "Departments",
                principalColumn: "Dep_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDep_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Emp_Phone",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Emp_Phone",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
