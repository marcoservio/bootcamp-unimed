using System.Collections.Generic;
using Colecoes.Helper;

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");

// Console.WriteLine("Percorrendo o array pelo For");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine(arrayInteiros[i]);
// }

// Console.WriteLine("Percorrendo o array pelo ForEach");
// foreach (var item in arrayInteiros)
// {
//     Console.WriteLine(item);
// }

// int[,] matriz = new int[4, 3]
// {
//     { 8, 8, 1 },
//     { 10, 20, 1 },
//     { 50, 100, 1 },
//     { 90, 200, 1 }
// };

// for (int linha = 0; linha < matriz.GetLength(0); linha++)
// {
//     for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
//     {
//         Console.Write(matriz[linha, coluna]);

//         if (coluna < matriz.GetLength(1) - 1)
//             Console.Write(", ");
//     }
//     Console.WriteLine();
// }

// OperacoesArray op = new OperacoesArray();
// int[] array = new int[5] { 6, 3, 8, 1, 9 };
// int[] arrayCopia = new int[10];

// Console.WriteLine("Array original");
// op.ImprimirArray(array);

//op.OrdenarBubbleSort(ref array);
//op.Ordenar(ref array);

// Console.WriteLine("Array ordenado");
// op.ImprimirArray(array);

// Console.WriteLine("Array antes da copia");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);

// Console.WriteLine("Array depois da copia");
// op.ImprimirArray(arrayCopia);

// int valorProcurado = 10;
// bool existe = op.Existe(array, valorProcurado);

// if (existe)
//     Console.WriteLine("Encontrei o valor {0}", valorProcurado);
// else
//     Console.WriteLine("Não econtrei o valor {0}", valorProcurado);

// int valorProcurado = 0;
// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
//     Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
// else
//     Console.WriteLine("Existem valores que não são maiores que {0}", valorProcurado);

// int valorProcurado = 9;

// int valorAchado = op.ObterValor(array, valorProcurado);

// if (valorAchado > 0)
//     Console.WriteLine("Encontrei o valor");
// else
//     Console.WriteLine("Não encontrei o valor");

// int valorProcurado = 8;

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
//     Console.WriteLine($"O indice do elemento {valorProcurado}, é: {indice}");
// else
//     Console.WriteLine("Valor não existente no array.");

// Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2);

// Console.WriteLine($"Capacidade atual do array apos redimensionar: {array.Length}");

// string[] arrayString = op.ConverterParaArrayString(array);

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string> { "DF" };
// string[] estadosArray = new string[2] { "SC", "MT" };

// estados.Add("SP");
// estados.Add("MG");
// estados.Add("BA");

// Console.WriteLine($"Quantidades de elementos na lista: {estados.Count}");

// opLista.ImprimirListaString(estados);
// Console.WriteLine();

// Console.WriteLine("Removendo o elemento");
// estados.Remove("MG");

// estados.AddRange(estadosArray);

// estados.Insert(1, "RJ");

// opLista.ImprimirListaString(estados);

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Marco");
// fila.Enqueue("Maria");
// fila.Enqueue("Ana");

// Console.WriteLine($"Pessoas na fila: {fila.Count}\n");
// while (fila.Count > 0)
// {
//     Console.WriteLine($"Vez de: {fila.Peek()}");
//     Console.WriteLine($"{fila.Dequeue()} atendindo");
//     Console.WriteLine();
// }
// Console.WriteLine($"Pessoas na fila: {fila.Count}");

// Stack<string> pilha = new Stack<string>();

// pilha.Push(".Net");
// pilha.Push("DDD");
// pilha.Push("Código Limpo");

// Console.WriteLine($"Livros para a leitura: {pilha.Count}\n");
// while (pilha.Count > 0)
// {
//     Console.WriteLine($"Proximo livro para a leitura: {pilha.Peek()}");
//     Console.WriteLine($"{pilha.Pop()} lido com sucesso");
//     Console.WriteLine();
// }
// Console.WriteLine($"Livros para a leitura: {pilha.Count}");

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
// }

// string valorProcurado = "BA";

// if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
//     Console.WriteLine(estadoEncontrado);
// else
//     Console.WriteLine($"Chave: {valorProcurado} não existe no dicionároio");

// Console.WriteLine($"Removendo o valor: {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
// }

// Console.WriteLine("Valor original");
// Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "BA - teste atualizacao";

// Console.WriteLine("Valor Atualizado");
// Console.WriteLine(estados[valorProcurado]);

int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

Console.WriteLine($"Minimo: {minimo}");
Console.WriteLine($"Maximo: {maximo}");
Console.WriteLine($"Medio: {medio}");
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

// var numerosParesQuery =
//         from num in arrayNumeros
//         where num % 2 == 0
//         orderby num
//         select num;

// var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

// Console.WriteLine("Numeros pares query: " + string.Join(", ", numerosParesQuery));
// Console.WriteLine("Numeros pares metodo: " + string.Join(", ", numerosParesMetodo));