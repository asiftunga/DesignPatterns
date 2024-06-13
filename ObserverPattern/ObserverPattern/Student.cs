namespace ObserverPattern;

public class Student
{
    public void DishUpdate(object? sender, DishEventArgs e)
    {
        Console.WriteLine($"There is a new dish 😍: '{e.Dish}'.");

        Console.WriteLine($"sender : {sender}   e : {e}");
    }
}