using System.ComponentModel;

namespace WebApplication1.DTO
{
    public class EmployeeDTO
    {
        [DisplayName("Employee Number")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public decimal Salary { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
