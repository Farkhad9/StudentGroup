using System.ComponentModel.DataAnnotations;

namespace StudentGroup.Dtos.GroupDtos
{
    public class GroupUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
