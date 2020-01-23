using System;
using System.Collections.Generic;
using System.Linq;
using Lesson8.Heros.Spells;
using Lesson8.Items.Potions;

namespace Lesson8
{
    public class Wizard : Hero
    {
        public int MannaCount { get; set; }
        public List<ISpell> Spells { get; set; }

        public Wizard(string name, Gender gender)
        {
            Name            = name;
            ProNoun         = gender == Gender.Male ? ProNoun.His : ProNoun.Her;
            Weapon          = Weapon.Staff;
            AttackStrength  = 300;
            DefenseStrength = 100;
            MannaCount      = 1000;
            HealthBar       = 1000;
            Potions         = new List<Potion>() { new MegaPotion() };
            Spells          = new List<ISpell>() { new Fireball(), new HealMe() };
        }

        /// <summary>
        /// This will call the Hero.Defend() and then
        /// this will do something specific to the wizard
        /// </summary>
        public override void Defend(Character opponent)
        {
            base.Defend(opponent); // This will call the Defend() in the Hero class

            if(HealthBar > 0)
            {
                // When a wizard defends he gets more manna
                MannaCount += 200;
                Console.WriteLine("{0} [wizard] has earned 200 Manna points", Name);
            }
        }

        /// <summary>
        /// Only a wizard can cast a spell, so this method is in the Wizard class
        /// </summary>
        public void CastSpell(SpellName name)
        {
            // Look up spell
            ISpell spell = Spells.Where(s => s.Name == name).FirstOrDefault();

            if (MannaCount >= spell.MannaCost)
            {
                // Generate the message
                var damageMessage  = $"dealing {spell.HealthPointEffect} damage";
                var healingMessage = $"giving {Name} {spell.HealthPointEffect} health points";
                var message        = "";

                switch (spell.Type)
                {
                    case SpellType.Attack:
                        message = damageMessage;
                        break;
                    case SpellType.Heal:
                        message = healingMessage;
                        HealthBar += spell.HealthPointEffect; // Increase wizard health bar
                        break;
                }

                // Decrease our Manna count
                MannaCount -= spell.MannaCost;

                // Cast the spell
                spell.Cast(Name);
            }
            else
            {
                Console.WriteLine("Not enough Manna to cast this spell");
            }
        }
    }
}
