using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.Data.Common;

namespace PetShop.Model
{
    public class Login 
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public bool isAdmin { get; set; }
    }
}
