using System;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new Flyable();
    }
    public override void Display()
    {
        Console.WriteLine("I'm RedheadDuck!");
    }
}
