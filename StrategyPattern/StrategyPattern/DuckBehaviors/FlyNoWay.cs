using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern.DuckBehaviors;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("can not fly");
    }
}