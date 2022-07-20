using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double _comprimento;
        private double _largura;
        private bool _valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                _comprimento = comprimento;
                _largura = largura;
                _valido = true;
            }
            else
            {
                Console.WriteLine("Valores invalidos");
            }
        }

        public double ObterArea()
        {
            if (_valido)
                return _comprimento * _largura;
            else
                Console.WriteLine("Preencha valores vaidos");

            return 0;
        }
    }
}