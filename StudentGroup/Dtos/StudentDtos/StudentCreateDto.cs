using System.ComponentModel.DataAnnotations;

namespace StudentGroup.Dtos.StudentDtos
{
    public class StudentCreateDto
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
        public int GroupId { get; set; }
    }
}
