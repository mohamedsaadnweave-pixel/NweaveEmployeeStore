using Company_Employee.Migrations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_Employee.Models
{
    public class Users
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Password {  get; set; }
        public DateTime CreatedDate { get; set; }
        public string User_Status {  get; set; }

    }
}
