namespace ObserverPattern;

public class DishEventArgs : EventArgs
{
    public string Dish { get; set; }

    public DishEventArgs(string dish)
    {
        Dish = dish;
    }
}