using StudentGroup.Dtos.StudentDtos;

namespace StudentGroup.Services
{
    public interface IStudentService
    {
        Task<List<StudentGetDto>> GetAllAsync();
        Task<StudentGetDto?> GetByIdAsync(int id);
        Task<StudentGetDto> CreateAsync(StudentCreateDto dto);
        Task<StudentGetDto> UpdateAsync(StudentUpdateDto dto);
        Task DeleteAsync(StudentDeleteDto dto);
    }
}
