using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public class WhiteWizard : Wizard
    {
        public WhiteWizard(string nome, int level, int hitPointsCurrent, int hitPointsTotal, int magicPointsCurrent, int magicPointsTotal, string heroType)
                                                      : base(nome, level, hitPointsCurrent, hitPointsTotal, magicPointsCurrent, magicPointsTotal, heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HitPointsCurrent = hitPointsCurrent;
            this.HitPointsTotal = hitPointsTotal;
            this.MagicPointsCurrent = magicPointsCurrent;
            this.MagicPointsTotal = magicPointsTotal;
            this.HeroType = heroType;
        }
    }
}