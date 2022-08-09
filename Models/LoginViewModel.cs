using System.ComponentModel.DataAnnotations;

namespace payment_center_3.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Login { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}