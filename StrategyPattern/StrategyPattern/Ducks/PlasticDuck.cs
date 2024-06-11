namespace StrategyPattern.Ducks;

public class PlasticDuck : Duck
{
    public override void Swim()
    {
        throw new NotImplementedException();
    }

    public override void Display()
    {
        Console.WriteLine("this is a rubber duck");
    }
}