using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Items.Potions
{
    public abstract class Potion
    {
        public PotionName Name { get; set; }
        public int HealthBoostAmount { get; set; }
        public double Price { get; set; }

        public void Drink(string characterName)
        {
            Console.WriteLine("{2} drank a {0} and have gained {1} health points!", Name, HealthBoostAmount, characterName);
        }
    }

    public enum PotionName
    {
        SimplePotion      ,
        SuperPotion       ,
        MegaPotion        ,
        SuperDuperPotion  
    }
}
