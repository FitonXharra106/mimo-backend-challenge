namespace MimoBackend.Dtos
{
    public class UserAchievementDTO
    {
        public int AchievementId { get; set; }
        public string AchievementName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Progress { get; set; }
        public bool IsCompleted { get; set; }
    }
}
