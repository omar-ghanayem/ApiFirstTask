﻿using System.ComponentModel;

namespace WebApplication1.DTO
{
    public class DepartmentDTO
    {
        [DisplayName("Department Number")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
