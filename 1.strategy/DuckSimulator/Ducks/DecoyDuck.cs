using System;
public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        QuackBehavior = new Mute();
        FlyBehavior = new NonFly();
    }
    public override void Display()
    {
        Console.WriteLine("I'm DecoyDuck!");
    }
}
