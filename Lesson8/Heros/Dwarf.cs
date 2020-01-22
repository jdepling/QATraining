using System;
using System.Collections.Generic;
using System.Text;
using Lesson8.Items.Potions;

namespace Lesson8
{
    public class Dwarf : Hero
    {
        public Dwarf(string name, Gender gender)
        {
            Name            = name;
            ProNoun         = gender == Gender.Male ? ProNoun.His : ProNoun.Her;
            Weapon          = Weapon.Axe;
            AttackStrength  = 250;
            DefenseStrength = 250;
            HealthBar       = 1200;
            Potions         = new List<Potion>() { new SimplePotion(), new SuperPotion(), new MegaPotion() };
        }
    }
}
