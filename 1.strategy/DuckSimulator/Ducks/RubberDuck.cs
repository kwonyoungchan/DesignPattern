using System;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        QuackBehavior = new Squeak();
        FlyBehavior = new NonFly();
    }
    public override void Display()
    {
        Console.WriteLine("I'm RubberDuck!");
    }
}
