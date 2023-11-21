using System.ComponentModel.DataAnnotations;

namespace WebAppSample.Models
{
    public class Register
    {
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", 
            ErrorMessage = "Password must have at least 8 characters, one uppercase letter, one lowercase letter, and one number.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password",
            ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmationPassword { get; set; }
    }
}
