namespace ObserverPattern;

public class SmartKitchen
{
    public event EventHandler<DishEventArgs>? DishEventHandler;

    public void CookAndNotify(string dish)
    {
        Console.WriteLine($"'{dish}' dish is being cooked..");

        Thread.Sleep(new Random().Next(1, 5) * 1000); //dish cooking time

        Console.WriteLine($"'{dish}' dish is ready! Enjoy, everyone :)");

        OnDishEventHandler(dish);

    }

    private void OnDishEventHandler(string dish)
    {
        DishEventHandler?.Invoke(this, new DishEventArgs(dish));
    }
}