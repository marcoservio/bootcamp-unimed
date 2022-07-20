using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

FileHelper helper = new FileHelper();
var path = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos");
var pathCriacao = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "Pasta Teste 3", "SubPastaTeste3");
var pathDelete = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "Pasta Teste 3");
var pathArquivo = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "arquivo-teste.txt");
var pathArquivoStream = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "arquivo-teste-stream.txt");
var novoPathArquivoStream = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "Pasta Teste 3", "SubPastaTeste3", "arquivo-teste-stream.txt");
var novoPathArquivoStreamCopy = Path.Combine(Environment.CurrentDirectory, "TrabalhandoComArquivos", "Pasta Teste 3", "SubPastaTeste3", "arquivo-teste-copy.txt");
var lstString = new List<string> { "linha1", "linha2", "linha3" };
var lstString2 = new List<string> { "linha4", "linha5", "linha6" };

// helper.ListarDiretorios(path);
// helper.ListarArquivosDiretorios(path);
// Console.WriteLine($"Criando diretorio: {pathCriacao}");
// helper.CriarDiretorio(pathCriacao);
// helper.ApagarDiretorio(pathDelete, true);
// helper.CriarArquivoTexto(pathArquivo, "Olá Teste de escrita de arquivo");
// helper.CriarArquivoTextoStream(pathArquivoStream, lstString);
// helper.AdcionarTextoStream(pathArquivoStream, lstString2);
// helper.LerArquivoStream(pathArquivoStream);
// helper.MoverArquivo(pathArquivoStream, novoPathArquivoStream, false);
// helper.CopiarArquivo(novoPathArquivoStream, novoPathArquivoStreamCopy, false);
helper.DeletarArquivo(novoPathArquivoStreamCopy);

// ICalculadora calc = new Calculadora();
// Console.WriteLine(calc.Somar(10, 20));


// Computador comp = new Computador();
// Console.WriteLine(comp.ToString());


// Corrente c = new Corrente();

// c.Creditar(100);
// c.Creditar(100);

// c.ExibirSaldo();


// Calculadora calc = new Calculadora();

// Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10, 10)}");
// Console.WriteLine($"Resultado da segunda soma: {calc.Somar(10, 10, 10)}");


// Aluno p1 = new Aluno();

// p1.Nome = "Bob";
// p1.Idade = 20;
// p1.Documento = "123445";
// p1.Nota = 10;

// p1.Apresentar();

// Professor p2 = new Professor();

// p2.Nome = "Bob";
// p2.Idade = 20;
// p2.Documento = "123445";
// p2.Salario = 2000;

// p2.Apresentar();


// Retangulo r = new Retangulo();

// r.DefinirMedidas(30, 30);
// Console.WriteLine($"Area: {r.ObterArea()}");

// Retangulo r2 = new Retangulo();

// r2.DefinirMedidas(0, 0);
// Console.WriteLine($"Area: {r2.ObterArea()}");


// Pessoa p1 = new Pessoa();

// p1.Nome = "Bob";
// p1.Idade = 20;

// p1.Apresentar();