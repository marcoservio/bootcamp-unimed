using DIO.Series.Classes;
using DIO.Series.Enum;

public class Program
{
    private static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3":
                    AtualizarSerie();
                    break;
                case "4":
                    ExcluirSerie();
                    break;
                case "5":
                    VisualizarSerie();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();
        }

        Console.WriteLine("Obrigado por utilizar nossos serviços.");
        Console.ReadLine();
    }

    static SerieRepositorio repositorio = new SerieRepositorio();

    private static void ExcluirSerie()
    {
        Console.Write("Digite o id da serie: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        Console.Write("Desenja meso excluir a série: [S/N] ");
        string valid = Console.ReadLine();

        if (valid.ToUpper() == "S")
            repositorio.Excluir(indiceSerie);
    }

    private static void VisualizarSerie()
    {
        Console.Write("Digite o id da serie: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        var serie = repositorio.RetornaPorId(indiceSerie);

        var excluido = serie.RetornaExcluido();

        if (!excluido)
            Console.WriteLine(serie);
    }

    private static void AtualizarSerie()
    {
        Console.Write("Digite o id da serie: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        int count = 1;
        foreach (var i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine($"{count}-{i}");
            count++;
        }

        Console.Write("Digite o genero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da serie: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de inicio da serie: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a descrição da serie: ");
        string entradaDescricao = Console.ReadLine();

        Serie atualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

        repositorio.Atualizar(indiceSerie, atualizaSerie);
    }

    private static void ListarSeries()
    {
        Console.WriteLine("Listar séries");

        var lista = repositorio.Lista();

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhuma série cadastrada.");
            return;
        }

        foreach (var serie in lista)
        {
            var excluido = serie.RetornaExcluido();

            if (!excluido)
                Console.WriteLine($"#ID {serie.RetornaId()}: - {serie.RetornaTitulo()}");
        }
    }

    private static void InserirSerie()
    {
        Console.WriteLine("Inserir nova série");

        int count = 1;
        foreach (var i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine($"{count}-{i}");
            count++;
        }

        Console.Write("Digite o genero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o Titulo da serie: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de inicio da serie: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite a descrição da serie: ");
        string entradaDescricao = Console.ReadLine();

        Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

        repositorio.Inserir(novaSerie);
    }

    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO Séries a seu dispor!!!");
        Console.WriteLine("Informe a opção desejada");

        Console.WriteLine("1 - Listar séries");
        Console.WriteLine("2 - Inserir nova séries");
        Console.WriteLine("3 - Atualizar séries");
        Console.WriteLine("4 - Excluir séries");
        Console.WriteLine("5 - Visualizar séries");
        Console.WriteLine("C - Limpar Tela");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
}