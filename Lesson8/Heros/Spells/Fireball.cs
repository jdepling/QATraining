using System;

namespace Lesson8.Heros.Spells
{
    public class Fireball : ISpell
    {
        public SpellName Name { get; set; }
        public int MannaCost { get; set; }
        public SpellType Type { get; set; }
        public int HealthPointEffect { get; set; }

        public Fireball()
        {
            Name              = SpellName.FireBall;
            MannaCost         = 100;
            Type              = SpellType.Attack;
            HealthPointEffect = 500;
        }

        public void Cast()
        {
            Console.WriteLine("You have cast a fireball and have dealt {0} damage. This cost {1} manna points", HealthPointEffect, MannaCost);
        }
    }
}
