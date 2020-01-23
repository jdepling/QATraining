using System;

namespace Lesson8.Heros.Spells
{
    public class HealMe : ISpell
    {
        public SpellName Name { get; set; }
        public int MannaCost { get; set; }
        public SpellType Type { get; set; }
        public int HealthPointEffect { get; set; }

        public HealMe()
        {
            Name              = SpellName.Healing;
            MannaCost         = 200;
            Type              = SpellType.Heal;
            HealthPointEffect = 1000;
        }

        public void Cast(string name)
        {
            Console.WriteLine("{0} casts a healing spell. Health has increased by {0}. This cost {1} manna points", HealthPointEffect, MannaCost, name);
        }
    }
}
