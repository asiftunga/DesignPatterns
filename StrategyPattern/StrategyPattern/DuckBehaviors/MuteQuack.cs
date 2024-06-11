using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern.DuckBehaviors;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("i am muted quack, i cant make noise");
    }
}