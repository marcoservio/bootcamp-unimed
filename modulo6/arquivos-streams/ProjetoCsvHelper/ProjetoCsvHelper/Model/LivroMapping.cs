using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCsvHelper.Model
{
    public class LivroMapping
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Preco { get; set; }
        public DateOnly Lancamento { get; set; }

        public LivroMapping()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Preco = decimal.Zero;
            Lancamento = DateOnly.MinValue;
        }
    }
}