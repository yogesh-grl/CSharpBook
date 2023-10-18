using System.ComponentModel.DataAnnotations;

namespace WebAppSample.Models
{
    public class Users
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}
