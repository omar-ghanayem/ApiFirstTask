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
    public class DepartmentsController : ControllerBase
    {

        ApplicationDbContext context = new ApplicationDbContext();

        [HttpGet("")]
        public IActionResult GetAll()
        {
            //var departments = context.Departments.ToList();
            var departments = context.Departments.ToList().Adapt<List<DepartmentDTO>>();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var department = context.Departments.Find(id);
            var departmentDTO = department.Adapt<DepartmentDTO>();
            return Ok(departmentDTO);
        }
        [HttpPost("")]
        public IActionResult Create(CreateDepartmentDTO request)
        {
            var department = request.Adapt<Department>();
            context.Departments.Add(department);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("")]
        public IActionResult Update(CreateDepartmentDTO request, int id)
        {
            var department = request.Adapt<Department>();
            department.Id = id;
            context.Departments.Update(department);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("")]
        public IActionResult Delete(int id)
        {
            var department = context.Departments.Find(id);
            context.Departments.Remove(department);
            context.SaveChanges();
            return Ok();
        }
    }
}
