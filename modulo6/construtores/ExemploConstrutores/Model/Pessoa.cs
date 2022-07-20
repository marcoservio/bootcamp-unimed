using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Model
{
    public class Pessoa
    {
        // readonly so pode ser alterado no construtor e na inicialização
        private readonly string nome = "Marco";
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}