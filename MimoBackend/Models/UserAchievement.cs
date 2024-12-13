namespace MimoBackend.Models
{
    public class UserAchievement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int AchievementId { get; set; }
        public Achievement Achievement { get; set; } = default!;
        public bool IsCompleted { get; set; }
        public int Progress { get; set; }
    }
}
