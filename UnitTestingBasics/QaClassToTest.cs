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
    public class QaClassToTest
    {
        /// <summary>
        /// Example method for testing
        /// </summary>
        public double MethodToTest(int quantity, Item itemToBuy = Item.BroomStick)
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
        public double AdrianneMethodToTest()
        {
            return 5;
        }

        /// <summary>
        /// Chris will create this method and test it
        /// </summary>
        public double ChrisMethodToTest()
        {
            return 5;
        }

        /// <summary>
        /// Matt will create this method and test it
        /// </summary>
        public double MattMethodToTest()
        {
            return 5;
        }

        /// <summary>
        /// Nick will create this method and test it
        /// </summary>
        public double NickMethodToTest()
        {
            return 5;
        }
    }
}
