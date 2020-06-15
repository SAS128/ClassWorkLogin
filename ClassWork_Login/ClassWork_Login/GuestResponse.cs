using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class GuestResponse
    {
        [Required]
        [StringLength(24, MinimumLength = 4, ErrorMessage = "Не допустимое имя!")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Плз введите ваш номерок")]
        //[RegularExpression(@"^\+[0-9]\d{3}-\d{3}-\d{4}$", ErrorMessage = "Не корректный номер!")]
        public string Phone { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}