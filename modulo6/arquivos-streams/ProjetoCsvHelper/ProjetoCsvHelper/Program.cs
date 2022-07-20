using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using ProjetoCsvHelper.Model;
using ProjetoCsvHelper.Mapping;

// LerCSVDynamic();
// LerCsvComClasse();
//LerCsvComOutroDelimitador();
//LerCsvComOutroDelimitadorSemCabecalho();
//LerCsvMapping();
EscreverCsv();

Console.WriteLine("Digite [enter] para finalizar....");
Console.ReadLine();

static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");

    var di = new DirectoryInfo(path);

    if (!di.Exists)
        di.Create();

    path = Path.Combine(path, "Usuarios.csv");

    var pessoas = new List<Pessoa>(){
        new Pessoa()
        {
            Nome = "Marco",
            Email = "ma@gmail.com",
            Telefone = 123456
        },
        new Pessoa()
        {
            Nome = "Pedro",
            Email = "pe@gmail.com",
            Telefone = 123457
        },
        new Pessoa()
        {
            Nome = "Maria",
            Email = "ma@gmail.com",
            Telefone = 123458
        },
        new Pessoa()
        {
            Nome = "Carla",
            Email = "ca@gmail.com",
            Telefone = 123459
        },
        new Pessoa()
        {
            Nome = "Joao",
            Email = "jo@gmail.com",
            Telefone = 1234551
        }
    };

    using var sr = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture)
    {
        Delimiter = "|"
    };
    using var csvWrite = new CsvWriter(sr, csvConfig);
    csvWrite.WriteRecords(pessoas);
}

static void LerCsvMapping()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Livros.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();
    var registros = csvReader.GetRecords<LivroMapping>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Titulo: {registro.Titulo}");
        Console.WriteLine($"Autor: {registro.Autor}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine($"Lançaamento: {registro.Lancamento}");
        Console.WriteLine("---------------");
    }
}

static void LerCsvComOutroDelimitadorSemCabecalho()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "LivrosSemCabecalho.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<LivroSemCabecalho>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Titulo: {registro.Titulo}");
        Console.WriteLine($"Autor: {registro.Autor}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine($"Lançaamento: {registro.Lancamento}");
        Console.WriteLine("---------------");
    }
}

static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Livros.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Titulo: {registro.Titulo}");
        Console.WriteLine($"Autor: {registro.Autor}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine($"Lançaamento: {registro.Lancamento}");
        Console.WriteLine("---------------");
    }
}

static void LerCsvComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Nome: {registro.Produto}");
        Console.WriteLine($"Marca: {registro.Marca}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine("---------------");
    }
}

static void LerCSVDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Nome: {registro.Produto}");
        Console.WriteLine($"Marca: {registro.Marca}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine("---------------");
    }
}
