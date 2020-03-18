using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopping = new OurTimeAtTheStore(new CreditCard(), new GroceryCart(new Prices()));
            
            shopping.PutInCart(2, Item.Milk);    // $4
            shopping.PutInCart(1, Item.Bread);  // $1
            shopping.PutInCart(4, Item.Bacon); // $20
            shopping.PutInCart(3, Item.Eggs); // $4.50
            shopping.PutInCart(2, Item.PanCakes); // $5.50
            // Total should be $35

            // What do I owe?
           var amount =  shopping.CheckPrice();

            Console.WriteLine($"You owe ${amount}. Do you wish to checkout?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");

            Int32.TryParse(Console.ReadLine(), out int response);

            if (response == 1)
                shopping.BuyWhatIsInCart();
            
            Console.WriteLine("Bye");
            

        }
    }
}
