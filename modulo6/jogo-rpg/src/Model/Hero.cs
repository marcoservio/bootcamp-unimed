using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg.src.Model
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HitPointsCurrent { get; set; }
        public int HitPointsTotal { get; set; }
        public int MagicPointsCurrent { get; set; }
        public int MagicPointsTotal { get; set; }
        public string HeroType { get; set; }

        public Hero()
        {
            this.Name = string.Empty;
            this.Level = 0;
            this.HitPointsCurrent = 0;
            this.HitPointsTotal = 0;
            this.MagicPointsCurrent = 0;
            this.MagicPointsTotal = 0;
            this.HeroType = string.Empty;
        }

        public Hero(string nome, int level, int hitPointsCurrent, int hitPointsTotal, int magicPointsCurrent, int magicPointsTotal, string heroType)
        {
            this.Name = nome;
            this.Level = level;
            this.HitPointsCurrent = hitPointsCurrent;
            this.HitPointsTotal = hitPointsTotal;
            this.MagicPointsCurrent = magicPointsCurrent;
            this.MagicPointsTotal = magicPointsTotal;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            return ($"{this.Name}\n   Lv.  {this.Level}   {this.HeroType}\n   HP  {this.HitPointsCurrent}/ {this.HitPointsTotal}\n   MP  {this.MagicPointsCurrent}/ {this.MagicPointsTotal}");
        }

        public virtual string Attack()
        {
            return "";
        }
    }
}