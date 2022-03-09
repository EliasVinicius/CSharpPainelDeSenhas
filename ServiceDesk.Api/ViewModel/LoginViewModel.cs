using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.API.ViewModel
{
    public class LoginViewModel
    {
        private string? _email;
        [Required(ErrorMessage = "Email Obrigatorio")]
        [EmailAddress(ErrorMessage = "Formato email invalido")]
        public string? Email
        {
            get => _email;
            set => _email = value ?? throw new ArgumentNullException("Email Obrigatorio");
        }

        [Required(ErrorMessage = "A Senha é obrigatoria")]
        [StringLength(20, ErrorMessage = "A {0} deve ter no minimo {2} e no máximo {1} caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
