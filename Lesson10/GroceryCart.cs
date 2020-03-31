using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10
{
    public class GroceryCart : IGroceryCart
    {
        private readonly Dictionary<Item, double> _cart;
        private readonly IPrices _prices;

        public GroceryCart(IPrices prices)
        {
            _cart = new Dictionary<Item, double>();
            _prices = prices; // This will be our pretend db
        }

        // We want to unit test this method without calling the DB
        public double Evaluate()
        {
            double sum = 0;

            foreach(Item item in _cart.Keys)
            {
                // This will look up the price in our DB. We don't want our unit tests to call the DB!
                sum += _prices.CheckPrice(item) * _cart[item];
            }

            return sum;
        }

        public void LoadItem(Item item, int quantity)
        {
            _cart.Add(item, quantity);
        }

        public Dictionary<Item, double> CheckCart()
        {
            return _cart;
        }

    }
}
