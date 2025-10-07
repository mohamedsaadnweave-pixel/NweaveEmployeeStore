using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_Employee.Models
{


    public class Employees
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set;}
        public int Emp_Age { get; set;}
        [Required]
        [Phone]
        public string Emp_Phone { get; set; }
        public string Emp_Address { get; set;}
        public int Emp_Status { get; set;}
        public DateTime CraetedDate { get; set; }
        public string CreatedBy { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
        
        public List<Devices> Devices { get; set; }
       
        

    }
}
