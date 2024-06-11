using StrategyPattern.DuckBehaviors.Services;

namespace StrategyPattern;

public abstract class Duck
{
    protected IFlyBehavior _flyBehavior;

    protected IQuackBehavior _quackBehavior;

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public abstract void Swim();

    public abstract void Display();
}