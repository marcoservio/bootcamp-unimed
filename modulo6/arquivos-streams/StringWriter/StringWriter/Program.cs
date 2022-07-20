string textReaderText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.\n\n" +

"Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.\n\n" +

"It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.\n\n";

Console.WriteLine($"Texto original: {textReaderText}");
string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();

    if (linha != null)
        paragrafo += linha + " ";
    else
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");

int caractereLido;
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caractereLido = sr.Read();

    if (caractereLido == -1)
        break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if (caractereConvertido == '.')
    {
        sw.Write(".");
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }
}

Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");

Console.WriteLine("\n\nDigite [enter] para finalizar...");
Console.ReadLine();