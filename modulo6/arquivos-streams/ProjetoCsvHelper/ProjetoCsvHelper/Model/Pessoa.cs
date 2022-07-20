using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCsvHelper.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }

        public Pessoa()
        {
            Nome = string.Empty;
            Email = string.Empty;
            Telefone = 0;
        }
    }
}