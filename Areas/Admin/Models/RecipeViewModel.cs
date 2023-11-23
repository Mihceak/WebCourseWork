using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace CourseWork.Areas.Admin.Models
{
    public class RecipeViewModel
    {
        [Required]
        [Display(Name = "Изображение")]
        public IFormFile Image { get; set; }
        
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
        [Display(Name = "Время подготовки")]
        public int PrepareTime { get; set; }
        
        [Required]
        [Display(Name = "Время готовки")]
        public int CookTime { get; set; }
    }
}