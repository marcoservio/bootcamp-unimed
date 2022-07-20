using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCsvHelper.Model
{
    public class Usuario
    {
        public string Produto { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }

        public Usuario()
        {
            Produto = string.Empty;
            Marca = string.Empty;
            Preco = decimal.Zero;
        }
    }
}