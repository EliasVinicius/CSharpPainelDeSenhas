using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.API.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma senha")]
        [Compare("Password", ErrorMessage = "Senhas nao conferem")]
        public string ConfirmPassword { get; set; }
    }
}
