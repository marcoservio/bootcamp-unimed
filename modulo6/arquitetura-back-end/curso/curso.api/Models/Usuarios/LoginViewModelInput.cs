using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "a Senha é obrigatoria")]
        public string Senha { get; set; }

        public LoginViewModelInput()
        {
            Login = string.Empty;
            Senha = string.Empty;
        }
    }
}
