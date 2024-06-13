using StrategyPattern.DuckBehaviors;

namespace StrategyPattern.Ducks;

public class ReadHeadDuck : Duck
{
    public ReadHeadDuck()
    {
        _quackBehavior = new Squack();
        _flyBehavior = new FlyWithWings();
    }

    public override void Swim()
    {
        Console.WriteLine("I can swim");
    }

    public override void Display()
    {
        Console.WriteLine("I am readhead duck");
    }
}