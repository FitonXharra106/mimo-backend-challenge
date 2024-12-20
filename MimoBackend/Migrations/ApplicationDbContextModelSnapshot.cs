﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MimoBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MimoBackend.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Achievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Complete any 5 lessons",
                            Name = "Complete 5 Lessons"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Complete any 25 lessons",
                            Name = "Complete 25 Lessons"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Complete any 50 lessons",
                            Name = "Complete 50 Lessons"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Complete any single chapter",
                            Name = "Complete 1 Chapter"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Complete any 5 chapters",
                            Name = "Complete 5 Chapters"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Complete all chapters in the Swift course",
                            Name = "Complete the Swift Course"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Complete all chapters in the Javascript course",
                            Name = "Complete the Javascript Course"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Complete all chapters in the C# course",
                            Name = "Complete the C# Course"
                        });
                });

            modelBuilder.Entity("MimoBackend.Models.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Chapters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Name = "Introduction to Swift",
                            Order = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Name = "Advanced Swift",
                            Order = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            Name = "Introduction to Javascript",
                            Order = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            Name = "Advanced Javascript",
                            Order = 2
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            Name = "Introduction to C#",
                            Order = 1
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            Name = "Advanced C#",
                            Order = 2
                        });
                });

            modelBuilder.Entity("MimoBackend.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Swift"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Javascript"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C#"
                        });
                });

            modelBuilder.Entity("MimoBackend.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChapterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChapterId = 1,
                            Name = "Variables and Constants",
                            Order = 1
                        },
                        new
                        {
                            Id = 2,
                            ChapterId = 1,
                            Name = "Functions",
                            Order = 2
                        },
                        new
                        {
                            Id = 3,
                            ChapterId = 2,
                            Name = "Classes and Structs",
                            Order = 1
                        },
                        new
                        {
                            Id = 4,
                            ChapterId = 2,
                            Name = "Protocols and Extensions",
                            Order = 2
                        },
                        new
                        {
                            Id = 5,
                            ChapterId = 3,
                            Name = "Variables and Data Types",
                            Order = 1
                        },
                        new
                        {
                            Id = 6,
                            ChapterId = 3,
                            Name = "Functions and Loops",
                            Order = 2
                        },
                        new
                        {
                            Id = 7,
                            ChapterId = 4,
                            Name = "ES6 Features",
                            Order = 1
                        },
                        new
                        {
                            Id = 8,
                            ChapterId = 4,
                            Name = "Promises and Async/Await",
                            Order = 2
                        },
                        new
                        {
                            Id = 9,
                            ChapterId = 5,
                            Name = "Hello World in C#",
                            Order = 1
                        },
                        new
                        {
                            Id = 10,
                            ChapterId = 5,
                            Name = "OOP Concepts in C#",
                            Order = 2
                        },
                        new
                        {
                            Id = 11,
                            ChapterId = 6,
                            Name = "LINQ Basics",
                            Order = 1
                        },
                        new
                        {
                            Id = 12,
                            ChapterId = 6,
                            Name = "Delegates and Events",
                            Order = 2
                        });
                });

            modelBuilder.Entity("MimoBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fiton Xharra"
                        });
                });

            modelBuilder.Entity("MimoBackend.Models.UserAchievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AchievementId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Progress")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAchievements");
                });

            modelBuilder.Entity("MimoBackend.Models.UserLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("UserLessons");
                });

            modelBuilder.Entity("MimoBackend.Models.Chapter", b =>
                {
                    b.HasOne("MimoBackend.Models.Course", "Course")
                        .WithMany("Chapters")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("MimoBackend.Models.Lesson", b =>
                {
                    b.HasOne("MimoBackend.Models.Chapter", "Chapter")
                        .WithMany("Lessons")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("MimoBackend.Models.UserAchievement", b =>
                {
                    b.HasOne("MimoBackend.Models.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MimoBackend.Models.User", "User")
                        .WithMany("Achievements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MimoBackend.Models.UserLesson", b =>
                {
                    b.HasOne("MimoBackend.Models.Lesson", "Lesson")
                        .WithMany("UserLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MimoBackend.Models.User", "User")
                        .WithMany("UserLessons")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MimoBackend.Models.Chapter", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("MimoBackend.Models.Course", b =>
                {
                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("MimoBackend.Models.Lesson", b =>
                {
                    b.Navigation("UserLessons");
                });

            modelBuilder.Entity("MimoBackend.Models.User", b =>
                {
                    b.Navigation("Achievements");

                    b.Navigation("UserLessons");
                });
#pragma warning restore 612, 618
        }
    }
}
