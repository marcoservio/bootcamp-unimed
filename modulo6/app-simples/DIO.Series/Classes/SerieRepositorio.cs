using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> lstSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            lstSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            lstSerie[id].Excluir();
        }

        public void Inserir(Serie entidade)
        {
            lstSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return lstSerie;
        }

        public int ProximoId()
        {
            return lstSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return lstSerie[id];
        }
    }
}