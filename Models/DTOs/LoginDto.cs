using System.ComponentModel.DataAnnotations;

namespace WebFrontEndPractice.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Please provide user email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide user password")]
        [MinLength(10)]
        public string Password { get; set; } = string.Empty;
    }
}
