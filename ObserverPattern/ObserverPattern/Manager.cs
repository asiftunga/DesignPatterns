namespace ObserverPattern;

public class Manager
{
    private readonly List<string> _dish;

    public Manager(List<string> dish)
    {
        _dish = dish;
    }

    public void DishUpdate(object? sender, DishEventArgs e)
    {
        if(_dish.Any(x => x.ToLower().Contains(e.Dish.ToLower())))
            Console.WriteLine($"There is a dish worthy of managers 😎: '{e.Dish}'.");

        Console.WriteLine($"sender : {sender}   e : {e}");
    }
}