namespace MimoBackend.Models
{
    public class UserLesson
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; } = default!;
        public DateTime StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
