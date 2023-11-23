using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseWork.Domain.Enums;

namespace CourseWork.Domain.Entities
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Количество")]
        public int Amount { get; set; }
        
        [Required]
        [Display(Name = "Единица измерения")]
        public Unit Unit { get; set; }
        
        [ForeignKey(nameof(IngredientList))]
        public Guid? IngredientListId { get; set; }
        public IngredientList IngredientList { get; set; }
    }
}