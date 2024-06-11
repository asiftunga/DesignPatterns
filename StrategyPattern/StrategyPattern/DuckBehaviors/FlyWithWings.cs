using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern.DuckBehaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("flying with wings");
    }
}