using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Name Surname")]
        [Required(ErrorMessage ="Please enter a name and surname")]
        public string  NameSurname { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }

        [Display(Name = "Password")]
        [Compare("Password",ErrorMessage = "Password are not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required( ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter an username")]
        public string Username { get; set; }
    }
}
