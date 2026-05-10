namespace StudentGroup.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int  Age  { get; set; }
        public string  Email { get; set; } = string.Empty;
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;     

    }

}
