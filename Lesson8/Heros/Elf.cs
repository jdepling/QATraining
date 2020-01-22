using System;
using System.Collections.Generic;
using Lesson8.Items.Potions;

namespace Lesson8
{
    public class Elf : Hero
    {
        public Elf(string name, Gender gender)
        {
            Name            = name;
            ProNoun         = gender == Gender.Male ? ProNoun.His : ProNoun.Her;
            Weapon          = Weapon.Bow;
            AttackStrength  = 350;
            DefenseStrength = 150;
            HealthBar       = 1200;
            Potions         = new List<Potion>() { new SimplePotion(), new SuperPotion(), new MegaPotion() };
        }
    }
}
