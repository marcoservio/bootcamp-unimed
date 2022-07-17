using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        var aluno = new Aluno();

                        Console.Write("Informe o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();

                        Console.Write("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                            aluno.Nota = nota;
                        else
                            throw new ArgumentException("O valor da nota deve ser decimal.");

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }

                        break;
                    case "3":
                        var notaTotal = decimal.Zero;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum conceitoGeral;

                        if(mediaGeral < 2)
                            conceitoGeral = ConceitoEnum.E;
                        else if(mediaGeral < 4)
                            conceitoGeral = ConceitoEnum.D;
                        else if(mediaGeral < 6)
                            conceitoGeral = ConceitoEnum.C;
                        else if(mediaGeral < 8)
                            conceitoGeral = ConceitoEnum.B;
                        else
                            conceitoGeral = ConceitoEnum.A;

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida!");
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            Console.Write("Digite a opção desejada: ");
            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
