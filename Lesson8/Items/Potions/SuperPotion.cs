using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Items.Potions
{
    public class SuperPotion : Potion
    {
        public SuperPotion()
        {
            Price             = 25.00;
            HealthBoostAmount = 150;
            Name              = PotionName.SuperPotion;
        }
    }
}
