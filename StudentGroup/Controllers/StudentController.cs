using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentGroup.Data;
using StudentGroup.Dtos.StudentDtos;

namespace StudentGroup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(AppDbContext _context) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students
                .Include(s => s.Group)
                .Select(s => new StudentGetDto
                {
                    Id = s.Id,
                    FullName = s.FullName,
                    Age = s.Age,
                    Email = s.Email,
                    GroupName = s.Group.Name
                })
                .ToListAsync();

            return Ok(students);
        }
    }
}