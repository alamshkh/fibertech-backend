using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FiberTechHR.Backend.Data;
using FiberTechHR.Backend.Models;

namespace FiberTechHR.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var data = await _context.Employees.ToListAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            await _context.SaveChangesAsync();
            return Ok(emp);
        }
    }
}