using Microsoft.EntityFrameworkCore;
using MimoBackend.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; } = default!;
    public DbSet<Chapter> Chapters { get; set; } = default!;
    public DbSet<Lesson> Lessons { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    public DbSet<UserLesson> UserLessons { get; set; } = default!;
    public DbSet<Achievement> Achievements { get; set; } = default!;
    public DbSet<UserAchievement> UserAchievements { get; set; } = default!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mimo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Seed Users
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "John Doe" },
            new User { Id = 2, Name = "Fiton Xharra" }
        );

        // Seed Courses
        modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, Name = "Swift" },
            new Course { Id = 2, Name = "Javascript" },
            new Course { Id = 3, Name = "C#" }
        );

        // Seed Chapters
        modelBuilder.Entity<Chapter>().HasData(
            new Chapter { Id = 1, Name = "Introduction to Swift", Order = 1, CourseId = 1 },
            new Chapter { Id = 2, Name = "Advanced Swift", Order = 2, CourseId = 1 },
            new Chapter { Id = 3, Name = "Introduction to Javascript", Order = 1, CourseId = 2 },
            new Chapter { Id = 4, Name = "Advanced Javascript", Order = 2, CourseId = 2 },
            new Chapter { Id = 5, Name = "Introduction to C#", Order = 1, CourseId = 3 },
            new Chapter { Id = 6, Name = "Advanced C#", Order = 2, CourseId = 3 }
        );

        // Seed Lessons
        modelBuilder.Entity<Lesson>().HasData(
            new Lesson { Id = 1, Name = "Variables and Constants", Order = 1, ChapterId = 1 },
            new Lesson { Id = 2, Name = "Functions", Order = 2, ChapterId = 1 },
            new Lesson { Id = 3, Name = "Classes and Structs", Order = 1, ChapterId = 2 },
            new Lesson { Id = 4, Name = "Protocols and Extensions", Order = 2, ChapterId = 2 },
            new Lesson { Id = 5, Name = "Variables and Data Types", Order = 1, ChapterId = 3 },
            new Lesson { Id = 6, Name = "Functions and Loops", Order = 2, ChapterId = 3 },
            new Lesson { Id = 7, Name = "ES6 Features", Order = 1, ChapterId = 4 },
            new Lesson { Id = 8, Name = "Promises and Async/Await", Order = 2, ChapterId = 4 },
            new Lesson { Id = 9, Name = "Hello World in C#", Order = 1, ChapterId = 5 },
            new Lesson { Id = 10, Name = "OOP Concepts in C#", Order = 2, ChapterId = 5 },
            new Lesson { Id = 11, Name = "LINQ Basics", Order = 1, ChapterId = 6 },
            new Lesson { Id = 12, Name = "Delegates and Events", Order = 2, ChapterId = 6 }
        );

        // Seed Achievements
        modelBuilder.Entity<Achievement>().HasData(
            new Achievement { Id = 1, Name = "Complete 5 Lessons", Description = "Complete any 5 lessons" },
            new Achievement { Id = 2, Name = "Complete 25 Lessons", Description = "Complete any 25 lessons" },
            new Achievement { Id = 3, Name = "Complete 50 Lessons", Description = "Complete any 50 lessons" },
            new Achievement { Id = 4, Name = "Complete 1 Chapter", Description = "Complete any single chapter" },
            new Achievement { Id = 5, Name = "Complete 5 Chapters", Description = "Complete any 5 chapters" },
            new Achievement { Id = 6, Name = "Complete the Swift Course", Description = "Complete all chapters in the Swift course" },
            new Achievement { Id = 7, Name = "Complete the Javascript Course", Description = "Complete all chapters in the Javascript course" },
            new Achievement { Id = 8, Name = "Complete the C# Course", Description = "Complete all chapters in the C# course" }
        );
    }
}
