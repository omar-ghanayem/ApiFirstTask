using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public decimal Salary { get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        
        public Department Department { get; set; }
    }
}
