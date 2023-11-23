using System;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Enums;

namespace CourseWork.Areas.Admin.Models
{
    public class IngredientViewModel
    {
        public string ReturnUrl { get; set; }
        
        public Guid IngredientListId { get; set; }
        
        public IngredientList IngredientList { get; set; }

        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public int Amount { get; set; }
        
        public Unit Unit { get; set; }
    }
}