﻿using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Department
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
