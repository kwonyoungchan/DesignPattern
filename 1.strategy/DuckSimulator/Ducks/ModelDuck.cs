using System;

public class ModelDuck:Duck
{
    public ModelDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new NonFly();
    }

    public override void Display()
    {
        Console.WriteLine("I'm RocketDuck!");
    }
}
