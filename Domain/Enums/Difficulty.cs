using System;

namespace CourseWork.Domain.Enums
{
    public enum Difficulty
    {
        Easy, Medium, Hard
    }
    
    public static class DifficultyExtension
    {
        public static string ToRussian(this Difficulty difficulty)
        {
            return difficulty switch
            {
                Difficulty.Easy => "Легко",
                Difficulty.Medium => "Средне",
                Difficulty.Hard => "Сложно",
                _ => throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null)
            };
        }
    }
}