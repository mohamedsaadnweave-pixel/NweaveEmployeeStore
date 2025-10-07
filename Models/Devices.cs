using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_Employee.Models
{
    public class Devices
    {
        [Key]
        public int Dev_Id { get; set; }
        public string Dev_Name { get; set; }
        public string? Dev_SerialNo { get; set; }
        public string? Dev_Description { get; set; }
        public string? Dev_Quant { get; set; }
        public DateTime UsingDate { get; set; }

        [ForeignKey("Employees")]
        public int Emp_Id {  get; set; }
        public Employees Employees { get; set; }
        public List<Maintenance> Maintenances { get; set; }
    }
}
