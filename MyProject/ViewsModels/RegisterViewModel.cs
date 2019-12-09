using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.ViewsModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "EmailRequired")]
        [StringLength(50, ErrorMessage = "EmailLenght", MinimumLength = 7)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "NameRequired")]
        [Range(1900, 2019, ErrorMessage = "NameRange")]
        [Display(Name = "Yearb")]
        public int Year { get; set; }

        [Required(ErrorMessage = "PasswordRequired")]        
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "PasswordLenght", MinimumLength = 5)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PasswordConfirmRequired")]        
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "PasswordConfirmLenght", MinimumLength = 5)]
        [Display(Name = "Confpassword")]
        public string PasswordConfirm { get; set; }
    }
}
