using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern.DuckBehaviors;

public class Quacks : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("i am quacking duck");
    }
}