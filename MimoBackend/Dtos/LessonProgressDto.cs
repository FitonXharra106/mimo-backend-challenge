namespace MimoBackend.Dtos
{
    public class LessonProgressDto
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? CompletionTime { get; set; }
    }
}
