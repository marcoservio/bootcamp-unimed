using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public class Knight : Hero
    {
        public Knight(string nome, int level, int hitPointsCurrent, int hitPointsTotal, int magicPointsCurrent, int magicPointsTotal, string heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HitPointsCurrent = hitPointsCurrent;
            this.HitPointsTotal = hitPointsTotal;
            this.MagicPointsCurrent = magicPointsCurrent;
            this.MagicPointsTotal = magicPointsTotal;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}