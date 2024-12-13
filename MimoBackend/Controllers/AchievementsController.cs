using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimoBackend.Dtos;
using MimoBackend.Models;

namespace MimoBackend.Controllers
{
    [ApiController]
    [Route("api/achievements")]
    public class AchievementsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AchievementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<List<UserAchievementDTO>>> GetAchievements(int userId)
        {
            // Fetch lessons completed by the user
            var completedLessonsCount = await _context.UserLessons
                .Where(ul => ul.UserId == userId && ul.CompletedAt != null)
                .Select(ul => ul.LessonId)
                .Distinct()
                .CountAsync();

            // Fetch chapters completed by the user
            var completedChaptersCount = await _context.Chapters
                .Where(ch => _context.UserLessons
                    .Where(ul => ul.UserId == userId && ul.CompletedAt != null)
                    .Select(ul => ul.LessonId)
                    .Distinct()
                    .Count(lessonId => ch.Lessons.Any(lesson => lesson.Id == lessonId))
                == ch.Lessons.Count)
                .CountAsync();

            // Fetch completed lessons for specific courses (Swift, JavaScript, C#)
            var completedSwiftLessons = await _context.Lessons
                .Where(l => l.Chapter.Course.Name == "Swift" && l.UserLessons.Any(ul => ul.UserId == userId && ul.CompletedAt != null))
                .Distinct()
                .CountAsync();

            var completedJavascriptLessons = await _context.Lessons
                .Where(l => l.Chapter.Course.Name == "Javascript" && l.UserLessons.Any(ul => ul.UserId == userId && ul.CompletedAt != null))
                .Distinct()
                .CountAsync();

            var completedCSharpLessons = await _context.Lessons
                .Where(l => l.Chapter.Course.Name == "C#" && l.UserLessons.Any(ul => ul.UserId == userId && ul.CompletedAt != null))
                .Distinct()
                .CountAsync();

            // Fetch the user's name
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Prepare achievements to be returned
            var achievements = new List<UserAchievementDTO>
            {
                new UserAchievementDTO
                {
                    AchievementId = 1,
                    AchievementName = "Complete 5 Lessons",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedLessonsCount,
                    IsCompleted = completedLessonsCount >= 5
                },
                new UserAchievementDTO
                {
                    AchievementId = 2,
                    AchievementName = "Complete 25 Lessons",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedLessonsCount,
                    IsCompleted = completedLessonsCount >= 25
                },
                new UserAchievementDTO
                {
                    AchievementId = 3,
                    AchievementName = "Complete 50 Lessons",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedLessonsCount,
                    IsCompleted = completedLessonsCount >= 50
                },
                new UserAchievementDTO
                {
                    AchievementId = 4,
                    AchievementName = "Complete 1 Chapter",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedChaptersCount,
                    IsCompleted = completedChaptersCount >= 1
                },
                new UserAchievementDTO
                {
                    AchievementId = 5,
                    AchievementName = "Complete 5 Chapters",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedChaptersCount,
                    IsCompleted = completedChaptersCount >= 5
                },
                new UserAchievementDTO
                {
                    AchievementId = 6,
                    AchievementName = "Complete Swift Course",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedSwiftLessons,
                    IsCompleted = completedSwiftLessons == _context.Lessons
                        .Where(l => l.Chapter.Course.Name == "Swift")
                        .Count()
                },
                new UserAchievementDTO
                {
                    AchievementId = 7,
                    AchievementName = "Complete Javascript Course",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedJavascriptLessons,
                    IsCompleted = completedJavascriptLessons == _context.Lessons
                        .Where(l => l.Chapter.Course.Name == "Javascript")
                        .Count()
                },
                new UserAchievementDTO
                {
                    AchievementId = 8,
                    AchievementName = "Complete C# Course",
                    UserId = userId,
                    UserName = user.Name,
                    Progress = completedCSharpLessons,
                    IsCompleted = completedCSharpLessons == _context.Lessons
                        .Where(l => l.Chapter.Course.Name == "C#")
                        .Count()
                }
            };

            // Save achievements to the database
            foreach (var achievement in achievements)
            {
                var existingAchievement = await _context.UserAchievements
                    .FirstOrDefaultAsync(ua => ua.UserId == userId && ua.AchievementId == achievement.AchievementId);

                if (existingAchievement != null)
                {
                    existingAchievement.Progress = achievement.Progress;
                    existingAchievement.IsCompleted = achievement.IsCompleted;
                    _context.UserAchievements.Update(existingAchievement);
                }
                else
                {
                    var newUserAchievement = new UserAchievement
                    {
                        AchievementId = achievement.AchievementId,
                        UserId = achievement.UserId,
                        Progress = achievement.Progress,
                        IsCompleted = achievement.IsCompleted
                    };
                    _context.UserAchievements.Add(newUserAchievement);
                }
            }

            await _context.SaveChangesAsync();

            return Ok(achievements);
        }
    }
}