using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        // public sealed override void Apresentar()
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou um professor, e ganho {Salario}");
        }
    }
}