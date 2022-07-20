CriarDiretorioGlobo();
CriarArquivo();

var origen = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");
CopiarArquivo(origen, destino);
var destinoCopy = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "argentina.txt");
MoverArquivo(origen, destinoCopy);

var path = Path.Combine(Environment.CurrentDirectory, "globo");
LerDiretorios(path);
LerArquivos(path);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não exite");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }

    File.Copy(pathOrigem, pathDestino);
}

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]: {fileInfo.Name}");
        Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");

        Console.WriteLine("-------------------------");
    }

}

static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            Console.WriteLine("-------------------------");
        }
    }
    else
        Console.WriteLine($"{path} não existe");
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não exite");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 19/07/2022");
    }
}

static void CriarDiretorioGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmericaNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmericaCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmericaSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmericaNorte.CreateSubdirectory("USA");
        dirAmericaNorte.CreateSubdirectory("Mexico");
        dirAmericaNorte.CreateSubdirectory("Canada");

        dirAmericaCentral.CreateSubdirectory("Costa Rica");
        dirAmericaCentral.CreateSubdirectory("Panama");

        dirAmericaSul.CreateSubdirectory("Brasil");
        dirAmericaSul.CreateSubdirectory("Argentina");
        dirAmericaSul.CreateSubdirectory("Paraguai");
    }
}