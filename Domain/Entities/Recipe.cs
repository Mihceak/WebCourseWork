using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseWork.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace CourseWork.Domain.Entities
{
    public class Recipe
    {

        public Recipe()
        {
            Steps = new List<string>();
            IngredientLists = new List<IngredientList>();
        }
        
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "Изображение")]
        public string ImageName { get; set; }
        
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Категория")]
        public Category Category { get; set; }
        
        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "Сложность")]
        public Difficulty Difficulty { get; set; }
        
        [Required]
        [Display(Name = "Время приготовления")]
        public int PrepareTime { get; set; }
        
        [Required]
        [Display(Name = "Время готовки")]
        public int CookTime { get; set; }
        
        [Display(Name = "Шаг ")]
        public List<string> Steps { get; set; }
        
        public ICollection<IngredientList> IngredientLists { get; set; }
    }
}