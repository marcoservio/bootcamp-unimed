using static System.Console;

Write("Digite o nome do arquivo: ");
var nome = ReadLine();

if (nome != null)
    LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivos(path);

Write("Digite enter para finalizar...");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }

    return nome;
}

static void CriarArquivos(string path)
{
    try
    {
        //File.Create(path);
        using var sw = File.CreateText(path); // using já descarrega no arquivo
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");
        //sw.Flush(); // Descarrega para o arquivo
    }
    catch
    {
        WriteLine("O nome do arquivo é invalido");
    }

}

