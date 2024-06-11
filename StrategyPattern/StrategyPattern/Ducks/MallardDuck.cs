using StrategyPattern.DuckBehaviors;

namespace StrategyPattern.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _quackBehavior = new Quacks();
        _flyBehavior = new FlyWithWings();
    }

    public override void Swim()
    {
        Console.WriteLine("i am swimming mallard duck");
    }

    public override void Display()
    {
        Console.WriteLine("mallard dack showed");
    }
}