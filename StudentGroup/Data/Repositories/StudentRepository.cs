using StudentGroup.Models;
using Microsoft.EntityFrameworkCore;
namespace StudentGroup.Data.Repositories
{
    public class StudentRepository(AppDbContext _context) : IStudentRepository
    {

        public async Task<List<Student>> GetAllAsync() => await _context.Students.ToListAsync();

        public async Task<Student> GetByIdAsync(int id) => await _context.Students.FindAsync(id);

        public async Task AddAsync(Student student) => await _context.Students.AddAsync(student);

        public void Update(Student student) => _context.Students.Update(student);

        public void Delete(Student student) => _context.Students.Remove(student);

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
