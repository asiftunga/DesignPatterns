namespace ObserverPattern;

public class Teacher
{
    private readonly List<string> _dish;

    public Teacher(List<string> dish)
    {
        _dish = dish;
    }

    public void DishUpdate(object? sender, DishEventArgs e)
    {
        if(_dish.Any(x => x.ToLower().Contains(e.Dish.ToLower())))
            Console.WriteLine($"There is a dish worthy of teachers 😅: '{e.Dish}'.");

        Console.WriteLine($"sender : {sender}   e : {e}");
    }
}