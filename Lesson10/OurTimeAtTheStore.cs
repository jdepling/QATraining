using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class OurTimeAtTheStore
    {
        private readonly ICreditCard _card;
        private readonly IGroceryCart _cart;

        public OurTimeAtTheStore(ICreditCard card, IGroceryCart cart)
        {
            _card = card;
            _cart = cart;
        }

        public void PutInCart(int quantity, Item item)
        {
            if (quantity > 0)
            {
                _cart.LoadItem(item, quantity);
            }
        }

        public double CheckPrice()
        {
            return _cart.Evaluate();
        }

        public bool BuyWhatIsInCart()
        {
            return _card.Swipe(_cart.Evaluate());
        }

    }
}
