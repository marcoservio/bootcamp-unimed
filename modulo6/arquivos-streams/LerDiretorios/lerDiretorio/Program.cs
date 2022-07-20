using System.IO;

var path = @"C:\Users\marco\OneDrive\git-marcoservio\bootcampUnimedBH\modulo6\arquivos-streams\Directory_And_Directory_Info\directory_and_directoryInfo\globo";
LerDiretorios(path);

Console.WriteLine("Digite [enter] para finalizar...");
Console.ReadLine();

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