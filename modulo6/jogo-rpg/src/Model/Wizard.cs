using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public class Wizard : Hero
    {
        public Wizard(string nome, int level, int hitPointsCurrent, int hitPointsTotal, int magicPointsCurrent, int magicPointsTotal, string heroType)
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
            return this.Name + " Lançou Magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return this.Name + " Lançou Magia super efetiva com bonus de " + bonus;

            return this.Name + " Lançou uma maiga com força fraca com bonos de " + bonus;
        }
    }
}