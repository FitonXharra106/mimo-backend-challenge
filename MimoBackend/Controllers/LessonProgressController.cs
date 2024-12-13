using Microsoft.AspNetCore.Mvc;
using MimoBackend.Dtos;
using MimoBackend.Models;

namespace MimoBackend.Controllers
{
    [ApiController]
    [Route("api/lesson-progress")]
    public class LessonProgressController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LessonProgressController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> TrackProgress([FromBody] LessonProgressDto dto)
        {
            // Validate that the lesson exists
            var lesson = await _context.Lessons.FindAsync(dto.LessonId);
            if (lesson == null)
            {
                return NotFound("Lesson not found.");
            }

            // Ensure StartedAt is smaller than CompletedAt
            if (dto.CompletionTime != null && dto.StartTime >= dto.CompletionTime)
            {
                return BadRequest("Start time must be earlier than completion time.");
            }

            var userLesson = new UserLesson
            {
                UserId = dto.UserId,
                LessonId = dto.LessonId,
                StartedAt = dto.StartTime,
                CompletedAt = dto.CompletionTime
            };

            // Add the new UserLesson to the database
            _context.UserLessons.Add(userLesson);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}