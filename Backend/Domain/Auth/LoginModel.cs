using System.ComponentModel.DataAnnotations;

namespace DDDNetCore
{
   public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}