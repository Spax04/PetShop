using Microsoft.Build.Framework;

namespace PetShop.Model
{
    public class Login
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
