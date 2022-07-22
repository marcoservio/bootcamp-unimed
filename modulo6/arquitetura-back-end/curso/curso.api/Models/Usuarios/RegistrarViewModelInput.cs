using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class RegistrarViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O Email é obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        public string Senha { get; set; }

        public RegistrarViewModelInput()
        {
            Login = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
        }
    }
}
