using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company_Employee.Migrations
{
    /// <inheritdoc />
    public partial class updateuserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employees_EmployeesEmp_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EmployeesEmp_Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeesEmp_Id",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeesEmp_Id",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeesEmp_Id",
                table: "Users",
                column: "EmployeesEmp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employees_EmployeesEmp_Id",
                table: "Users",
                column: "EmployeesEmp_Id",
                principalTable: "Employees",
                principalColumn: "Emp_Id");
        }
    }
}
