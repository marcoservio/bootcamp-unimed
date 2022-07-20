using ExemploConstrutores.Model;

Matematica m = new Matematica(10, 20);
m.Somar();


// public delegate void Operacao(int x, int y);

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Operacao op = Calculadora.Somar;
//         Operacao op = new Operacao(Calculadora.Somar);
//         op += Calculadora.Subtrair;
//         op.Invoke(10, 10);

//         op(10,10);
//     }
// }


// const double pi = 3.14;
// Console.WriteLine(pi);


// Data data = new Data();
// data.SetMes(2);

// data.Mes = 20;
// Console.WriteLine(data.Mes);

// data.ApresentarMes();


// Log log = Log.GetInstance();

// log.PropriedadeLog = "Teste instancia";

// Log log2 = Log.GetInstance();

// Console.WriteLine(log2.PropriedadeLog);


// Aluno p1 = new Aluno("Marco", "Sérvio", "C#");
// p1.Apresentar();


// Pessoa p1 = new Pessoa("Marco", "Sérvio");
// p1.Apresentar();
