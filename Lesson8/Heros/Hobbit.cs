using System;
using System.Collections.Generic;
using Lesson8.Items.Potions;

namespace Lesson8.Heros
{
    public class Hobbit : Hero
    {
        public Hobbit(string name, Gender gender)
        {
            Name            = name;
            ProNoun         = gender == Gender.Male ? ProNoun.His : ProNoun.Her;
            Weapon          = Weapon.HobbitSword;
            AttackStrength  = 100;
            DefenseStrength = 100;
            HealthBar       = 400;
            Potions         = new List<Potion>() { new SimplePotion(), new SuperPotion(), new MegaPotion() };
        }
    }
}
