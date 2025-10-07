using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_Employee.Models
{
    public class Maintenance
    {
        [Key]
        public int Main_ID { get; set; }
        public string Main_Description { get; set; }
        public DateTime Main_Date { get; set;} = DateTime.Now;
        [ForeignKey("Devices")]
        public int Dev_Id { get; set; }
        public Devices Devices { get; set; }

    }
}
