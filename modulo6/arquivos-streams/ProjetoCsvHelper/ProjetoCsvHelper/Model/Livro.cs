using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace ProjetoCsvHelper.Model
{
    public class Livro
    {
        [Name("titulo")]
        public string Titulo { get; set; }
        [Name("autor")]
        public string Autor { get; set; }
        [Name("preco")]
        [CultureInfo("pt-BR")]
        public decimal Preco { get; set; }
        [Name("lancamento")]
        [Format("dd/MM/yyyy")]
        public DateOnly Lancamento { get; set; }

        public Livro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Preco = decimal.Zero;
            Lancamento = DateOnly.MinValue;
        }
    }
}