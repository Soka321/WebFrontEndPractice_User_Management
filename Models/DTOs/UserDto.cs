using System.ComponentModel.DataAnnotations;

namespace WebFrontEndPractice.Models.DTOs
{
    public class UserDto
    {
        [Required(ErrorMessage = "Please provide user name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide user surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please provide user email")]
        [EmailAddress(ErrorMessage ="Please provide correct Email address")]
        public string Email { get; set; }
    }
}
