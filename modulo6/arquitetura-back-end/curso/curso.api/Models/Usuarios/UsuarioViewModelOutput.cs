namespace curso.api.Models.Usuarios
{
    public class UsuarioViewModelOutput
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }

        public UsuarioViewModelOutput()
        {
            Codigo = 0;
            Email = string.Empty;
            Login = string.Empty;
        }
    }
}
