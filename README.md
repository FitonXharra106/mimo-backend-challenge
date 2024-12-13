# Mimo Backend Project

## Overview

This project is designed to manage a simple educational platform. It tracks courses, chapters, lessons, achievements, and user progress through these entities. The backend is implemented using ASP.NET Core with Entity Framework Core, and it uses SQLite as the database for storing data.

## Features

- **Courses**: Courses are the primary structure of the platform, each containing chapters and lessons.
- **Chapters**: Each course has multiple chapters. Chapters are ordered and have a name.
- **Lessons**: Lessons are the core educational content for each chapter. They are ordered and associated with chapters.
- **Achievements**: Users earn achievements based on their progress in completing lessons and chapters.
- **User Progress**: Tracks the user’s completion of lessons and chapters, allowing them to unlock achievements.
  
## Entity Models

1. **Course**: Represents a course with a unique ID and name.
2. **Chapter**: Represents a chapter within a course. It contains a name and an order indicating its position within the course.
3. **Lesson**: Represents a lesson in a chapter. Each lesson has an order to define its sequence in the chapter.
4. **User**: Represents a user of the platform. Users can complete lessons and chapters, and they are tracked with their achievements.
5. **Achievement**: Represents an achievement that a user can earn. Achievements are tied to the completion of lessons, chapters, or courses.
6. **UserAchievement**: Tracks which achievements have been earned by users and their progress.

## Database Setup

The project uses SQLite to store the data in a file named `mimo.db`. It includes seed data for courses, chapters, lessons, and achievements that are populated upon the first run.

## Technologies Used

- **ASP.NET Core**: Backend framework
- **Entity Framework Core**: ORM for database interaction
- **SQLite**: Database
- **C#**: Programming language
- **LINQ**: For querying and filtering data

## Getting Started

### Prerequisites

- .NET 6.0 or higher
- SQLite (SQLite is bundled in the project, no installation needed)

### Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/FitonXharra106/mimo-backend-challenge.git
    cd mimo-backend
    ```

2. **Install dependencies**:
    - Open the project in Visual Studio or your preferred C# IDE.
    - Restore the required NuGet packages:
      ```bash
      dotnet restore
      ```

3. **Build the project**:
    ```bash
    dotnet build
    ```

4. **Run the project**:
    - Start the application using:
      ```bash
      dotnet run
      ```

### Database Initialization

Upon the first launch, the application will automatically create a SQLite database (`mimo.db`) and populate it with the predefined data for courses, chapters, lessons, and achievements.

### Endpoints

This backend provides a simple structure that can be expanded with API endpoints to handle user data, lesson completion, and achievement tracking. You can create controllers and services to expose these functionalities via HTTP endpoints.

### Seed Data

The seed data includes:

- **Courses**: Swift, Javascript, and C#.
- **Chapters**: Two chapters per course (Introduction and Advanced).
- **Lessons**: Two lessons per chapter, covering basic to advanced topics.
- **Achievements**: Achievements such as completing lessons and chapters (e.g., "Complete 5 Lessons", "Complete Swift Course").

## Achievement Tracking Logic

The backend includes logic for tracking user achievements based on their progress in completing lessons and chapters. For example:
- **Complete 5 Lessons**: The user earns this achievement after completing 5 lessons.
- **Complete Swift Course**: The user earns this achievement after completing all lessons in the Swift course.

Each achievement is stored in the `UserAchievement` table, and the progress is updated based on the number of lessons or chapters completed.

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests. Please follow the guidelines for submitting your changes.
