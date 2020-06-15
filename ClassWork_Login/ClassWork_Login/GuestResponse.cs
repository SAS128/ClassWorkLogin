using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class GuestResponse
    {
        [Required]
        [StringLength(24, MinimumLength = 4, ErrorMessage = "Не допустимое имя!")]
        [RegularExpression(@"^\<[:alpha:]$", ErrorMessage = "Начало логина должно начинаться с буквы")]
        public string Login { get; set; }
        //--------------------------------------------------------------------------------------------
        [Required]
        public string Password { get; set; }
        //--------------------------------------------------------------------------------------------
        [Required]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Не коректный ввод телефона(больше или меньше нужного количества символов)")]
        [RegularExpression(@"^\+[0-9]\d{10}$", ErrorMessage = "Не корректный номер!")]
        public string Phone { get; set; }
        //--------------------------------------------------------------------------------------------
        [Required]
        public string Email { get; set; }
        //--------------------------------------------------------------------------------------------
    }
}