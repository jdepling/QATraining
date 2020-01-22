using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Items.Potions
{
    public class SuperDuperPotion : Potion
    {
        public SuperDuperPotion()
        {
            Price             = 100.00;
            HealthBoostAmount = 500;
            Name              = PotionName.SuperDuperPotion;
        }
    }
}
