using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class CreditCard : ICreditCard
    {
        public bool Swipe(object amount)
        {
            return true;
        }
    }
}
