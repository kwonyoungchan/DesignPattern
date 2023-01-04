using System;
public class NonFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("이 새는 날지 못해요.");
    }
}
