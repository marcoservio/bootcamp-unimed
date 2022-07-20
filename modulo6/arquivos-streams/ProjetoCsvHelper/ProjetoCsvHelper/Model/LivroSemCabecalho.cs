using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace ProjetoCsvHelper.Model
{
    public class LivroSemCabecalho
    {
        [Index(0)]
        public string Titulo { get; set; }
        [Index(2)]
        public string Autor { get; set; }
        [Index(1)]
        [CultureInfo("pt-BR")]
        public decimal Preco { get; set; }
        [Index(3)]
        [Format("dd/MM/yyyy")]
        public DateOnly Lancamento { get; set; }

        public LivroSemCabecalho()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Preco = decimal.Zero;
            Lancamento = DateOnly.MinValue;
        }
    }
}