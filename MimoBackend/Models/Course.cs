namespace MimoBackend.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
    }
}
