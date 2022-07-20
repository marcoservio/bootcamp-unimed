using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Model
{
    public class Data
    {
        private int _mes;
        private bool _mesValido;

        public int GetMes()
        {
            return _mes;
        }
        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                _mes = mes;
                _mesValido = true;
            }
        }

        public int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    _mes = value;
                    _mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if (_mesValido)
                Console.WriteLine(_mes);
            else
                Console.WriteLine("Mês inválido.");
        }
    }
}