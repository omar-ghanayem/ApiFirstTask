using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();

        [HttpGet("")]

        public IActionResult GetAll()
        {
            var employees = context.Employees.ToList().Adapt<List<EmployeeDTO>>();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = context.Employees.Find(id);
            var employeeDTO = employee.Adapt<CreateEmployeeDTO>();
            return Ok(employeeDTO);
        }
        [HttpPost("")]
        public IActionResult Create(CreateEmployeeDTO request)
        {
            var employee = request.Adapt<Employee>();
            context.Employees.Add(employee);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("")]
        public IActionResult Update(CreateEmployeeDTO request,int id) {
            var employee = request.Adapt<Employee>();
            employee.Id = id;
            context.Employees.Update(employee);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("")]
        public IActionResult Delete(int id) {
            var employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
            return Ok();
        }

    }
}
