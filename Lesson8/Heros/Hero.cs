using System;
using System.Collections.Generic;
using System.Linq;
using Lesson8.Items.Potions;

namespace Lesson8
{
    public abstract class Hero : Character
    {
        protected int Virtue = 100;
        public List<Potion> Potions { get; set; }
        public Weapon Weapon { get; set; }
        public double Wealth { get; set; }
        public Gender Gender { get; set; }
        public ProNoun ProNoun { get; set; }

        /// <summary>
        /// All Characters need to be able to defend. This method was inherited from Characters.
        /// We need to add the override key word to be able to use it.
        /// Also, I decided to give the defend method an implementation because I don't want to make this same exact method in every single
        /// class that inherits from hero
        /// </summary>
        public override void Defend(Character opponent)
        {
            int damageDone = 0;
            if (opponent.AttackStrength > DefenseStrength)
            {
                // Calculate damage done to hero
                damageDone = opponent.AttackStrength - DefenseStrength;
                Console.WriteLine("You are protected by {0} points", Virtue);
                damageDone -= Virtue;

                if (damageDone > 0)
                    HealthBar -= damageDone;
                else
                    damageDone = 0;
            }

            Console.WriteLine("{2} uses {3} defense strength and blocks {0} points of damage. Damage received: {1}", DefenseStrength, damageDone, Name, ProNoun);
        }

        public override void Attack(Character opponent)
        {
            Console.WriteLine("{0} [{4}], attacks with {1} {2} and deals {3} damage points ", Name, ProNoun, Weapon, AttackStrength, GetType().Name);
        }

        /// <summary>
        /// Drink Potion is a method that is specific to heros. I did not inherit it from Character. Therefore I don't need the override keyword.
        /// Also, I don't want to rewrite this method for every single class that inherits from hero, so I am making one to rule them all here.
        /// </summary>
        public void DrinkPotion(PotionName PotionName)
        {
            Potion p = Potions.Where(p => p.Name == PotionName).FirstOrDefault();
            p.Drink(Name);

            // Potions give you a health boost. So make sure to increase your health bar!
            HealthBar += p.HealthBoostAmount;

            // Potions are a one time use, so remove it from your list of potions
            Potions.Remove(p);
        }
    }

    // These are enums that are specific to heros
    public enum Gender
    {
        Male,
        Female
    }

    public enum ProNoun
    {
        His,
        Her
    }

    public enum Weapon
    {
        Sword,
        Staff,
        Bow,
        HobbitSword,
        Axe
    }
}
