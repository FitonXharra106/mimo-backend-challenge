namespace MimoBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<UserLesson> UserLessons { get; set; } = new List<UserLesson>();
        public ICollection<UserAchievement> Achievements { get; set; } = new List<UserAchievement>();
    }
}
