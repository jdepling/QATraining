using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Items.Potions
{
    public class MegaPotion : Potion
    {
        public MegaPotion()
        {
            Price             = 50.00;
            HealthBoostAmount = 250;
            Name              = PotionName.MegaPotion;
        }
    }
}
