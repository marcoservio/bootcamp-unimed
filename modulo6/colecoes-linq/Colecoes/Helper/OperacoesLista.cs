using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Indice: {i}, Valor: {lista[i]}");
            }
        }
    }
}