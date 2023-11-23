using System;

namespace CourseWork.Areas.Admin.Models
{
    public class IngredientListViewModel
    {
        public Guid RecipeId { get; set; }
        
        public string Purpose { get; set; }
    }
}