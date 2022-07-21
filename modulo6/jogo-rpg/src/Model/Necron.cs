using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public class Necron : IBoss
    {
        public int Name { get; set; }

        public string Hadouken()
        {
            return "Hadouuuuuken";
        }
    }
}