namespace MimoBackend.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Order { get; set; }
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; } = default!;
        public ICollection<UserLesson> UserLessons { get; set; } = new List<UserLesson>();
    }
}
