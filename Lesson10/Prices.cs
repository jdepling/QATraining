using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class Prices : IPrices
    {
        private readonly Dictionary<Item, double> _priceLookUp;

        public Prices()
        {
            _priceLookUp = new Dictionary<Item, double>()
            {
                {Item.Milk, 2 },
                {Item.Bread, 1 },
                {Item.Eggs, 1.5 },
                {Item.Butter, 2.5 },
                {Item.Pork, 3.5 },
                {Item.PanCakes, 2.75 },
                {Item.Bacon, 5 },
            };
        }

        public double CheckPrice(Item item)
        {
            return _priceLookUp[item];
        }
    }
}
