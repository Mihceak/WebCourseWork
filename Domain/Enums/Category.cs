using System;

namespace CourseWork.Domain.Enums
{
    public enum Category
    {
        First, Second, Dessert, Drink
    }
    
    public static class CategoryExtension 
    {
        public static string ToRussian(this Category category)
        {
            return category switch {
                Category.First => "Первые блюда",
                Category.Second => "Вторые блюда",
                Category.Dessert => "Десерты",
                Category.Drink => "Напитки",
                _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
            };
        }
    }
}