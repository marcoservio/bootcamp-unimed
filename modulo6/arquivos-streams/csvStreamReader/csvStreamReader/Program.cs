CriarCsv();
LerCsv();

Console.WriteLine("\n\nPrecione [enter] para finalizar...");
Console.ReadLine();

static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");

    var pessoas = new List<Pessoa>(){
        new Pessoa()
        {
            Nome = "Marco",
            Email = "ma@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
        },
        new Pessoa()
        {
            Nome = "Pedro",
            Email = "pe@gmail.com",
            Telefone = 123457,
            Nascimento = new DateOnly(year: 1971, month: 3, day: 15)
        },
        new Pessoa()
        {
            Nome = "Maria",
            Email = "ma@gmail.com",
            Telefone = 123458,
            Nascimento = new DateOnly(year: 1972, month: 4, day: 16)
        },
        new Pessoa()
        {
            Nome = "Carla",
            Email = "ca@gmail.com",
            Telefone = 123459,
            Nascimento = new DateOnly(year: 1973, month: 5, day: 17)
        },
        new Pessoa()
        {
            Nome = "Joao",
            Email = "jo@gmail.com",
            Telefone = 123455,
            Nascimento = new DateOnly(year: 1974, month: 6, day: 18)
        }
    };

    var di = new DirectoryInfo(path);

    if (!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }

    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

static void LerCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuario-exportacao.csv");

    if (!File.Exists(path))
    {
        Console.WriteLine($"Arquivo no caminho {path} não encontrado");
        return;
    }

    using var sr = new StreamReader(path);
    var cabecalho = sr.ReadLine()?.Split(',');

    while (true)
    {
        var registro = sr.ReadLine()?.Split(',');

        if (registro == null)
            break;

        if (cabecalho?.Length != registro.Length)
        {
            Console.WriteLine("Arquivo fora do padrão");
            break;
        }

        for (int i = 0; i < registro.Length; i++)
        {
            Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
        }

        Console.WriteLine("---------------");
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }

    public Pessoa()
    {
        Nome = string.Empty;
        Email = string.Empty;
        Telefone = 0;
        Nascimento = DateOnly.MinValue;
    }
}