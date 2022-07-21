using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public interface IBoss
    {
        public int Name { get; set; }

        public string Hadouken();
    }
}