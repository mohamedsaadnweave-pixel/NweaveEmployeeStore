using System.ComponentModel.DataAnnotations;

namespace Company_Employee.Models
{
    public class Department
    {
        [Key]
        public int Dep_Id { get; set; }
        public string Dep_Name { get; set; }
        public string Dep_Description { get; set; }
        public string Dep_Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy {  get; set; }
        public List<Employees> Employees { get; set; }

    }
}
