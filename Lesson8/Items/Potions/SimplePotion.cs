using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Items.Potions
{
    public class SimplePotion : Potion
    {
        public SimplePotion()
        {
            Price             = 10.00;
            HealthBoostAmount = 50;
            Name              = PotionName.SimplePotion;
        }
    }
}
