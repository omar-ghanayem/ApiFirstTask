using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Department> Departments {  get; set; }
        public DbSet<Employee> Employees { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=ApiFirstTask;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "HR", Description = "Human Resources Department", Phone = "111-111-1111", Email = "hr@company.com", Address = "Building A" },
                new Department { Id = 2, Name = "IT", Description = "Information Technology Department", Phone = "222-222-2222", Email = "it@company.com", Address = "Building B" },
                new Department { Id = 3, Name = "Finance", Description = "Finance Department", Phone = "333-333-3333", Email = "finance@company.com", Address = "Building C" }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                // HR Employees
                new Employee { Id = 1, Name = "Alice", EmailAddress = "alice@company.com", Salary = 5000, Phone = "111-111-1001", Address = "City Center", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob", EmailAddress = "bob@company.com", Salary = 5200, Phone = "111-111-1002",  Address = "East Side", DepartmentId = 1 },
                new Employee { Id = 3, Name = "Charlie", EmailAddress = "charlie@company.com", Salary = 4800, Phone = "111-111-1003",  Address = "West End", DepartmentId = 1 },
                new Employee { Id = 4, Name = "Diana", EmailAddress = "diana@company.com", Salary = 5100, Phone = "111-111-1004",  Address = "North Town", DepartmentId = 1 },

                // IT Employees
                new Employee { Id = 5, Name = "Edward", EmailAddress = "edward@company.com", Salary = 6000, Phone = "222-222-2001",  Address = "City Center", DepartmentId = 2 },
                new Employee { Id = 6, Name = "Fiona", EmailAddress = "fiona@company.com", Salary = 6200, Phone = "222-222-2002", Address = "South Side", DepartmentId = 2 },
                new Employee { Id = 7, Name = "George", EmailAddress = "george@company.com", Salary = 6100, Phone = "222-222-2003",  Address = "East Side", DepartmentId = 2 },
                new Employee { Id = 8, Name = "Hannah", EmailAddress = "hannah@company.com", Salary = 6300, Phone = "222-222-2004",  Address = "West End", DepartmentId = 2 },

                // Finance Employees
                new Employee { Id = 9, Name = "Ian", EmailAddress = "ian@company.com", Salary = 5500, Phone = "333-333-3001",  Address = "Downtown", DepartmentId = 3 },
                new Employee { Id = 10, Name = "Julia", EmailAddress = "julia@company.com", Salary = 5400, Phone = "333-333-3002",  Address = "City Center", DepartmentId = 3 },
                new Employee { Id = 11, Name = "Kevin", EmailAddress = "kevin@company.com", Salary = 5300, Phone = "333-333-3003",  Address = "South Side", DepartmentId = 3 },
                new Employee { Id = 12, Name = "Laura", EmailAddress = "laura@company.com", Salary = 5600, Phone = "333-333-3004",  Address = "West End", DepartmentId = 3 }
            );
        }

    }
}
