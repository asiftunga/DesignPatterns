using StrategyPattern;
using StrategyPattern.Ducks;

MallardDuck mallardDuck = new();

mallardDuck.PerformQuack();
mallardDuck.PerformFly();
mallardDuck.Swim();
mallardDuck.Display();

ReadHeadDuck readHeadDuck = new();

readHeadDuck.PerformQuack();
readHeadDuck.PerformFly();
readHeadDuck.Swim();
readHeadDuck.Display();

PlasticDuck plasticDuck = new();

plasticDuck.PerformQuack();
plasticDuck.PerformFly();
plasticDuck.Swim();
plasticDuck.Display();