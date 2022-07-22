namespace curso.api.Models.Cursos
{
    public class CursosViewModelInput
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public CursosViewModelInput()
        {
            Nome = string.Empty;
            Descricao = string.Empty;
        }
    }
}
