using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern.DuckBehaviors;

public class Squack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("i cant quack i only squack!!");
    }
}