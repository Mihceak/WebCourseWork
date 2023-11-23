using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Почта")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required] 
        [Display(Name = "Повторите пароль")] 
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}