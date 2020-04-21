using System;
using System.Collections.Generic;

namespace UnitTestingBasics
{
    public enum Item
    {
        BroomStick,
        PitchFork,
        Shotgun,
        Chocolate,
        Burrito,
        IndianCurry,
        SomeDNDThing,
        FirstAmericanStock
    }

    public enum Weapon
    {
        BrassKnuckles,
        Slingshot,
        StunGun,
        BBGun,
        BaseballBat,
        CombatKnife,
        Pistol,
        Shotgun,
        M4,
        Bazooka
    }


    public class QaClassToTest
    {
        public Dictionary<Weapon, int> WeaponDictionary { get; set; }
        public QaClassToTest()
        {
            WeaponDictionary = new Dictionary<Weapon, int>()
            {
                {Weapon.BrassKnuckles, 10},
                {Weapon.Slingshot, 20},
                {Weapon.StunGun, 30},
                {Weapon.BBGun, 40},
                {Weapon.BaseballBat, 50},
                {Weapon.CombatKnife, 60},
                {Weapon.Pistol, 70},
                {Weapon.Shotgun, 80},
                {Weapon.M4, 90},
                {Weapon.Bazooka, 100}
            };
        }

        /// <summary>
        /// Example method for testing
        /// </summary>
        public double Purchase(int quantity, Item itemToBuy = Item.BroomStick)
        {
            double amountYouOwe = 0;
            quantity = quantity < 0 ? 0 : quantity;

            switch (itemToBuy)
            {
                case Item.BroomStick:
                    amountYouOwe += quantity * 5.0;
                    break;
                case Item.PitchFork:
                    amountYouOwe += quantity * 10.0;
                    break;
                case Item.Shotgun:
                    amountYouOwe += quantity * 300.0;
                    break;
                case Item.Chocolate:
                    amountYouOwe += quantity * 25.0;
                    break;
                case Item.Burrito:
                    amountYouOwe += quantity * 5.45;
                    break;
                case Item.IndianCurry:
                case Item.SomeDNDThing:
                case Item.FirstAmericanStock:
                    amountYouOwe += quantity * 0;
                    break;
            }

            return amountYouOwe;
        }

        /// <summary>
        /// Adrianne will create this method and test it
        /// </summary>
        public bool AdrianneIsFullOfPizza(int slicesOfPizza)
        {
            if (slicesOfPizza >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
         }

        /// <summary>
        /// Chris will create this method and test it
        /// </summary>
        public Weapon RandomWeapon()
        {
            var weaponArray = new Weapon[]
            {
                Weapon.BrassKnuckles,
                Weapon.Slingshot,
                Weapon.StunGun,
                Weapon.BBGun,
                Weapon.BaseballBat,
                Weapon.CombatKnife,
                Weapon.Pistol,
                Weapon.Shotgun,
                Weapon.M4,
                Weapon.Bazooka,
            };

            Random random = new Random();
            var weaponChoice = random.Next(weaponArray.Length);
            return weaponArray[weaponChoice];
        }



        public Weapon DecideWinner(Weapon yourWeapon, int yourWeaponAttackStrength, Weapon randomWeapon, int randomWeaponAttackStrength)
        {
            if (yourWeaponAttackStrength > randomWeaponAttackStrength)
            {
                return yourWeapon;
            }

            else return randomWeapon;
        }

        /// <summary>
        /// Matt will create this method and test it
        /// </summary>
        public int CowWrangle(int NumCows, int NumCowboys, int DaysWranglin)
        {
            NumCows -= (NumCowboys * 6) * DaysWranglin;

            if (NumCows <= 0)
            {
                NumCows = 0;
            }
        
            return NumCows;
        }

        /// <summary>
        /// Nick will create this method and test it
        /// </summary>
        public string NickMethodToTest(string someName, string someThing, int pickANumber)
        {
            string name = someName;
            string thing = someThing;
            string phrase = "";
            int phraseToUse = pickANumber;

            switch (pickANumber)
            {
                case 1:
                    phrase = $"My name is {name}, and my favorite thing is a {thing}.";
                    break;
                case 2:
                    phrase = $"Whatchu talkin' 'bout, {name}? This ain't my dad, this is a {thing}!!! (throw it on the ground)";
                    break;
                case 3:
                    phrase = $"I fear no {name}, but that {thing}... it scares me.";
                    break;
                default:
                    phrase = "My name is Kevin, and.... I don't know that number.";
                    break;
            }
            return phrase;
        }
    }
}
