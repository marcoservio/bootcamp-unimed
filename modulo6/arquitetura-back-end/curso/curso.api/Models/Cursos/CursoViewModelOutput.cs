namespace curso.api.Models.Cursos
{
    public class CursoViewModelOutput
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Login { get; set; }

        public CursoViewModelOutput()
        {
            Nome = string.Empty;
            Descricao = string.Empty;
            Login = string.Empty;
        }
    }
}
