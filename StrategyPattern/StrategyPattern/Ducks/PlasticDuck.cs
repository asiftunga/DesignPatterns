using StrategyPattern.DuckBehaviors;

namespace StrategyPattern.Ducks;

public class PlasticDuck : Duck
{
    public PlasticDuck()
    {
        _quackBehavior = new MuteQuack();
        _flyBehavior = new FlyNoWay();
    }


    public override void Swim()
    {
        Console.WriteLine("i can swim");
    }

    public override void Display()
    {
        Console.WriteLine("this is a rubber duck");
    }
}