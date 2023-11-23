using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Entities
{
    public class IngredientList
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Ингредиенты (ex. для теста)")]
        public string Purpose { get; set; }

        [ForeignKey(nameof(Recipe))]
        public Guid? RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}