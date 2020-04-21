using System;

namespace UnitTestingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            QaClassToTest ourClass = new QaClassToTest();
            
            // Use our example method
            var exampleMethodOutput = ourClass.Purchase(2, Item.Shotgun);
            Console.WriteLine("ExampleMethodOutput: {0:C}", exampleMethodOutput);

            // Use Adrianne's method
            bool hungerGone = ourClass.AdrianneIsFullOfPizza(3);
            Console.WriteLine("Is Adrianne full? {0}", hungerGone);

            // Use Chris's method
            Weapon randomWeapon = ourClass.RandomWeapon();
            var attackStrength = ourClass.WeaponDictionary[randomWeapon];
            var battleWinner = ourClass.DecideWinner(Weapon.Pistol, ourClass.WeaponDictionary[Weapon.Pistol], randomWeapon, attackStrength);
            Console.WriteLine(battleWinner);

            // Use Matt's method
            
            int NumCows = 100;
            int DaysWranglin = 7;
            int NumCowboys = 6;

            NumCows = ourClass.CowWrangle(NumCows, NumCowboys, DaysWranglin);


            if (NumCows <= 0)
            {
                Console.WriteLine($"The fields have been wrangled for {DaysWranglin} days by {NumCowboys} Cowboys and all of the cows are gone.");
            }
            else
            {
                Console.WriteLine($"The fields have been wrangled for {DaysWranglin} days by {NumCowboys} Cowboys. By the looks of it there are around {NumCows} left.");
            }

            // Use Nick's method
            var phrase = ourClass.NickMethodToTest("Eight Time NBA All-Star Dikembe Mutombo", "sawed-off shotty", 2);
            Console.WriteLine(phrase);
        }
    }
}
