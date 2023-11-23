using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string Username { get; set; }
        
        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
}