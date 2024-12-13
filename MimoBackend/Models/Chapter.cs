namespace MimoBackend.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Order { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
