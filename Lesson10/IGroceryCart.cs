namespace Lesson10
{
    public interface IGroceryCart
    {
        void LoadItem(Item item, int quantity);
        double Evaluate();
    }
}